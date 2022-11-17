using KappaESB.Classes;
using KappaESB.Interfaces.Processors;

namespace KappaESB.Endpoints
{
    public abstract class Endpoint<Request, Response> : EndpointBase, IEndpoint<Request, Response>
        where Request : class
        where Response : class
    {
        public Endpoint(string name, string description)
            : base(name, description)
        {

        }

        public Response ProcessMessage(Transfer<Request> message)
        {
            return ProcessMessageAsync(message).Result;
        }

        public abstract Task<Response> ProcessMessageAsync(Transfer<Request> message);
    }
}
