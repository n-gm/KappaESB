using KappaESB.Classes;
using KappaESB.Endpoints;

namespace KappaESB.Core.Endpoints
{
    internal class InternalSyncEndpoint<Request, Response> : Endpoint<Request, Response>
        where Request : class
        where Response : class
    {
        public Func<Transfer<Request>, Response> EndpointAction { get; set; }

        public InternalSyncEndpoint(string name, string description)
            : base(name, description)
        {

        }

        public override async Task<Response> ProcessMessageAsync(Transfer<Request> message)
        {
            return EndpointAction.Invoke(message);
        }
    }
}
