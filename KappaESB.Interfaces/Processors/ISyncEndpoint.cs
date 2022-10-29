using KappaESB.Interfaces.Common;

namespace KappaESB.Interfaces.Processors
{
    public interface ISyncEndpoint<Request, Response> : INamedEntity
        where Response : class
        where Request : class
    {
        Response ProcessMessage(Request message);
    }
}
