using KappaESB.Interfaces.Common;

namespace KappaESB.Core.Methods
{
    internal class EsbMethod : INamedEntity
    {
        private List<string> _endpoints;
        public string Name { get; private set; }
        public string Description { get; private set; }
        public IReadOnlyList<string> Endpoints => _endpoints;
        
        public EsbMethod(string name, string description)
        {
            Name = name;
            Description = description;
            _endpoints = new List<string>();
        }

        public void AddEndpoint(string endpointName)
        {
            _endpoints.Add(endpointName);
        }
    }
}
