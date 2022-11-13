using KappaESB.Classes;
using KappaESB.Interfaces.Common;
using KappaESB.Interfaces.Processors;

namespace KappaESB.Interfaces.Builders.Endpoints
{
    public interface IEndpointBuilder<Request> : INamedEntity where Request : class                    
    {
        /// <summary>
        /// Route message to endpoint by name. Can be used only if endpoint with endpointName was declared.
        /// </summary>
        /// <typeparam name="Response">Type of response returned by endpoint</typeparam>
        /// <param name="endpointName"></param>
        /// <returns></returns>
        IEndpointBuilder<Response> RouteToEndpoint<Response>(string endpointName) 
            where Response : class;
        /// <summary>
        /// Perform action based on current workflow data 
        /// </summary>
        /// <typeparam name="Response"></typeparam>
        /// <typeparam name="Endpoint">Endpoint implementation. Constructor must be parameterless</param>
        /// <param name="isLocal">If true endpoint will be deployed with main core. Set to false if you want to deploy endpoint in external container.</param>
        /// <returns></returns>
        IEndpointBuilder<Response> UseEndpoint<Response, Endpoint>(bool isLocal = true)
            where Response : class
            where Endpoint : ISyncEndpoint<Request, Response>, new();
        /// <summary>
        /// Perform action based on current workflow data 
        /// </summary>
        /// <typeparam name="Response"></typeparam>
        /// <param name="endpointName">Unique endpoint name. If you want to use one logic multiple time then use RouteToEndpoint.</param>
        /// <param name="func"></param>
        /// <returns></returns>
        IEndpointBuilder<Response> DoAsync<Response>(string endpointName, Func<Transfer<Request>, Task<Response>> func) 
            where Response : class;
        /// <summary>
        /// Perform action based on current workflow data 
        /// </summary>
        /// <typeparam name="Response"></typeparam>
        /// <typeparam name="Endpoint">Endpoint implementation. Constructor must be parameterless</param>
        /// <param name="isLocal">If true endpoint will be deployed with main core. Set to false if you want to deploy endpoint in outer container.</param>
        /// <returns></returns>
        IEndpointBuilder<Response> UseAsyncEndpoint<Response, Endpoint>(bool isLocal = true)
            where Response : class
            where Endpoint : IAsyncEndpoint<Request, Response>, new();
        /// <summary>
        /// Perform action based on current workflow data 
        /// </summary>
        /// <typeparam name="Response"></typeparam>
        /// <param name="endpointName">Unique endpoint name. If you want to use one logic multiple time then use RouteToEndpoint.</param>
        /// <param name="func"></param>
        /// <returns></returns>
        IEndpointBuilder<Response> Do<Response>(string endpointName, Func<Transfer<Request>, Response> func) 
            where Response : class;
        /// <summary>
        /// Convert from one type to another without requests to other systems
        /// </summary>
        /// <typeparam name="Response"></typeparam>
        /// <param name="func"></param>
        /// <returns></returns>
        IEndpointBuilder<Response> Convert<Response>(Func<Transfer<Request>, Response> func)
            where Response : class;
        /// <summary>
        /// Condition based on current workflow data
        /// </summary>
        /// <param name="condition"></param>
        /// <returns></returns>
        IEndpointBuilder<Request> If(Func<Request, bool> condition);
        IEndpointBuilder<Request> ElseIf(Func<Request, bool> condition);
        IEndpointBuilder<Request> Else();
        IEndpointBuilder<Request> EndIf();
    }
}
