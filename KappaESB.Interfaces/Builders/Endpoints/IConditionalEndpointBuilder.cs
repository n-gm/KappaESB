namespace KappaESB.Interfaces.Builders.Endpoints
{
    public interface IConditionalEndpointBuilder<Request> : IEndpointBaseBuilder<Request, IConditionalEndpointBuilder<Request>>
        where Request : class
    {
        IConditionalEndpointBuilder<Request> ElseIf(Func<Request, bool> condition);
        IConditionalEndpointBuilder<Request> Else(Func<Request, bool> condition);
        IEndpointBuilder<Request> EndIf();
    }
}
