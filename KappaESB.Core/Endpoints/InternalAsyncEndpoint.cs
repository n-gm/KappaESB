using KappaESB.Classes;
using KappaESB.Endpoints;

namespace KappaESB.Core.Endpoints
{
    internal class InternalAsyncEndpoint<Request, Response> : Endpoint<Request, Response>
        where Request : class
        where Response : class
    {
        public Func<Transfer<Request>, Task<Response>> EndpointAction { get; set; }

        public InternalAsyncEndpoint(string name, string description)
            : base(name, description)
        {

        }

        public override async Task<Response> ProcessMessageAsync(Transfer<Request> message)
        {
            return await EndpointAction.Invoke(message);
        }
    }
}
