using KappaESB.Interfaces.Processors;

namespace KappaESB.Core.Endpoints
{
    internal abstract class EsbEndpoint<Request, Response> : EsbEndpointBase, IEndpoint<Request, Response>
        where Request : class
        where Response : class
    {
        public EsbEndpoint(string name, string description)
            : base(name, description)
        {

        }

        public abstract Task<Response> ProcessMessageAsync(Request message);
    }
}
