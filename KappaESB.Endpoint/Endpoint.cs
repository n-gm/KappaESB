using KappaESB.Classes;
using KappaESB.Clients.KappaMQ;
using KappaESB.Clients.RabbitMQ;
using KappaESB.Interfaces.Processors;
using KappaESB.Interfaces.Transport;

namespace KappaESB.Endpoints
{
    public abstract class Endpoint<Request, Response> : EndpointBase, IEndpoint<Request, Response>
        where Request : class
        where Response : class
    {
        private IClient<Request, Response> _client;
        private bool disposedValue;

        public Endpoint(string name, string description, EndpointSettings settings)
            : base(name, description, settings)
        {
            _client = settings.QueueType switch
            {
                Classes.Common.QueueType.RabbitMQ => new RabbitMQClient<Request, Response>(name),
                _ => new KappaMQClient<Request, Response>(name),
            };
            _client.OnMessage = OnMessage;
            _client.Connect(settings.QueueConnectionString);
        }

        public Response ProcessMessage(Transfer<Request> message)
        {
            return ProcessMessageAsync(message).Result;
        }

        public abstract Task<Response> ProcessMessageAsync(Transfer<Request> message);

        private async Task OnMessage(string messageId, Transfer<Request> request)
        {
            try
            {
                var result = await ProcessMessageAsync(request);
                var response = new Transfer<Response>()
                {
                    Metadata = request.Metadata,
                    RouteId = request.RouteId,
                    Request = request.Request,
                    Response = result
                };
                response.Metadata.RetryCount = 0;
                _client.SendResponse(response);
            } catch
            {
                request.Metadata.RetryCount++;
                if (request.Metadata.RetryCount > request.Metadata.MaxRetryCount)
                    _client.Decline(messageId, DeclineActionType.Delete);
                else
                    _client.Decline(messageId, DeclineActionType.ReturnToEndOfQueue);
            }
        }

        protected void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                }
                _client.Dispose();
                disposedValue = true;
            }
        }

        ~Endpoint()
        {
             // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
             Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
