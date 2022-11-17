using KappaESB.Interfaces.Common;

namespace KappaESB.Core.Builders
{
    internal abstract class EndpointBuilderBase : INamedEntity
    {
        public EndpointType EndpointType { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
    }
}
