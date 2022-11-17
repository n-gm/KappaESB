using KappaESB.Classes;
using KappaESB.Interfaces.Common;

namespace KappaESB.Interfaces.Processors
{
    public interface ISyncEndpoint<Request, Response> : INamedEntity, IDisposable
        where Response : class
        where Request : class
    {
        Response ProcessMessage(Transfer<Request> message);
    }
}
