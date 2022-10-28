namespace KappaESB.Interfaces.Endpoint
{
    public interface IEndpointBuilder<Request> where Request : class
    {
        IEndpointBuilder<Response> Do<Response>(Func<Request, Response> func) where Response:class;
    }
}
