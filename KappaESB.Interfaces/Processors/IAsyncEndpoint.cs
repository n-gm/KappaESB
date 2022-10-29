using KappaESB.Interfaces.Common;

namespace KappaESB.Interfaces.Processors
{
    public interface IAsyncEndpoint<Request, Response> : INamedEntity
        where Response : class
        where Request : class
    {
        Task<Response> ProcessMessageAsync(Request message);
    }
}
