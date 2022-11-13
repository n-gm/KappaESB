using KappaESB.Classes;

namespace KappaESB.Core.Builders
{
    internal abstract class EndpointBuilderBase
    {
        public EndpointType EndpointType { get; protected set; }
        public abstract object Perform(TransferInfo request);
    }
}
