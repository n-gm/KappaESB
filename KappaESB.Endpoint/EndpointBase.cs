namespace KappaESB.Endpoints
{
    public abstract class EndpointBase
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public EndpointBase(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
