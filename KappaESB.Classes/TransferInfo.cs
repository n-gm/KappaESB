using KappaESB.Classes.Requests;

namespace KappaESB.Classes
{
    public abstract class TransferInfo
    {
        public Guid RouteId { get; set; }
        public TransferMetadata Metadata { get; set; }
        public RequestData Request { get; set; }
    }
}
