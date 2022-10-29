using KappaESB.Interfaces.Common;
using KappaESB.Interfaces.Processors;

namespace KappaESB.Core.Endpoints
{
    internal abstract class EsbEndpointBase
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public EsbEndpointBase(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
