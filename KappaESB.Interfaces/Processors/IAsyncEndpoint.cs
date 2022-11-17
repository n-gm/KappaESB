using KappaESB.Classes;
using KappaESB.Interfaces.Common;

namespace KappaESB.Interfaces.Processors
{
    public interface IAsyncEndpoint<Request, Response> : INamedEntity, IDisposable
        where Response : class
        where Request : class
    {
        Task<Response> ProcessMessageAsync(Transfer<Request> message);
    }
}
