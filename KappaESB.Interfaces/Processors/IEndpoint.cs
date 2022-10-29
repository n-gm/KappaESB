namespace KappaESB.Interfaces.Processors
{
    public interface IEndpoint<Request,Response> : IAsyncEndpoint<Request, Response>, ISyncEndpoint<Request, Response>
        where Request: class
        where Response: class
    {
        sealed new Response ProcessMessage(Request message)
        {
            return ProcessMessageAsync(message).Result;
        }        
    }
}
