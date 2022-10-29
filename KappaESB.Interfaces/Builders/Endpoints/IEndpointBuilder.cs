using KappaESB.Classes;
using KappaESB.Interfaces.Processors;

namespace KappaESB.Interfaces.Builders.Endpoints
{
    public interface IEndpointBuilder<Request> where Request : class
    {
        IEndpointBuilder<Response> RouteToEndpoint<Response>(string endpointName) where Response : class;
        /// <summary>
        /// Perform action based on current workflow data 
        /// </summary>
        /// <typeparam name="Response"></typeparam>
        /// <param name="func"></param>
        /// <returns></returns>
        IEndpointBuilder<Response> DoAsync<Response>(IAsyncEndpoint<Request, Response> endpoint) where Response : class;
        /// <summary>
        /// Perform action based on current workflow data 
        /// </summary>
        /// <typeparam name="Response"></typeparam>
        /// <param name="func"></param>
        /// <returns></returns>
        IEndpointBuilder<Response> DoAsync<Response>(Func<Transfer<Request>, Task<Transfer<Response>>> func) where Response : class;
        /// <summary>
        /// Perform action based on current workflow data 
        /// </summary>
        /// <typeparam name="Response"></typeparam>
        /// <param name="func"></param>
        /// <returns></returns>
        IEndpointBuilder<Response> Do<Response>(ISyncEndpoint<Request, Response> processor) where Response : class;
        /// <summary>
        /// Perform action based on current workflow data 
        /// </summary>
        /// <typeparam name="Response"></typeparam>
        /// <param name="func"></param>
        /// <returns></returns>
        IEndpointBuilder<Response> Do<Response>(Func<Transfer<Request>, Transfer<Response>> func) where Response : class;
        /// <summary>
        /// Convert from one type to another without requests to other systems
        /// </summary>
        /// <typeparam name="Response"></typeparam>
        /// <param name="func"></param>
        /// <returns></returns>
        IEndpointBuilder<Response> Convert<Response>(Func<Transfer<Request>, Transfer<Response>> func) where Response: class;
    }
}
