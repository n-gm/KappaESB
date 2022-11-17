namespace KappaESB.Endpoints
{
    public abstract class EndpointBase
    {
        protected EndpointSettings _settings;
        public string Name { get; private set; }
        public string Description { get; private set; }

        public EndpointBase(string name, string description, EndpointSettings settings)
        {
            Name = name;
            Description = description;
            _settings = settings;
        }
    }
}
