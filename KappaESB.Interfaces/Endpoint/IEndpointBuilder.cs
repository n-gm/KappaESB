namespace KappaESB.Interfaces.Endpoint
{
    public interface IEndpointBuilder<Request> where Request : class
    {
        /// <summary>
        /// Perform action based on current workflow data 
        /// </summary>
        /// <typeparam name="Response"></typeparam>
        /// <param name="func"></param>
        /// <returns></returns>
        IEndpointBuilder<Response> Do<Response>(Func<Request, Task<Response>> func) where Response : class;
        /// <summary>
        /// Convert from one type to another without requests to other systems
        /// </summary>
        /// <typeparam name="Response"></typeparam>
        /// <param name="func"></param>
        /// <returns></returns>
        IEndpointBuilder<Response> Convert<Response>(Func<Request, Task<Response>> func) where Response: class;
    }
}
