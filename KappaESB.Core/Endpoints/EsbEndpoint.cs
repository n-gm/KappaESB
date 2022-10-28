using KappaESB.Interfaces.Common;

namespace KappaESB.MainBuilder.Endpoints
{
    internal class EsbEndpoint : INamedBuilder
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public EsbEndpoint(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
