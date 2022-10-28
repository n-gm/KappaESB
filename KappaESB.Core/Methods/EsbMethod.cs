using KappaESB.Interfaces.Common;

namespace KappaESB.MainBuilder.Methods
{
    internal class EsbMethod : INamedBuilder
    {
        private List<string> _endpoints;
        public string Name { get; private set; }
        public string Description { get; private set; }
        public IEnumerable<string> Endpoints => _endpoints;
        
        public EsbMethod(string name, string description)
        {
            Name = name;
            Description = description;
            _endpoints = new List<string>();
        }
    }
}
