using KappaESB.Classes;
using KappaESB.Interfaces.Transport;

namespace KappaESB.Clients.RabbitMQ
{
    public class RabbitMQClient<Request, Response> : IClient<Request, Response>
        where Request : class
        where Response : class
    {
        public Func<string, Transfer<Request>, Task> OnMessage { get; set; }
        public string QueueName { get; private set; }
        public RabbitMQClient(string queueName)
        {
            QueueName = queueName;
        }

        public void Accept(string messageId)
        {
            throw new NotImplementedException();
        }

        public void Decline(string messageId, DeclineActionType action = DeclineActionType.ReturnToQueue)
        {
            throw new NotImplementedException();
        }

        public Transfer<Request> NextMessage()
        {
            throw new NotImplementedException();
        }

        public void SendResponse(Transfer<Response> response)
        {
            throw new NotImplementedException();
        }

        public void Connect(string connectionString)
        {
            throw new NotImplementedException();
        }
    }
}
