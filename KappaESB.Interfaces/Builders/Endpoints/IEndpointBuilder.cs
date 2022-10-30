namespace KappaESB.Interfaces.Builders.Endpoints
{
    public interface IEndpointBuilder<Request> : IEndpointBaseBuilder<Request, IEndpointBuilder<Request>>
        where Request : class
    {
        IConditionalEndpointBuilder<Request> If(Func<Request, bool> condition);
    }
}
