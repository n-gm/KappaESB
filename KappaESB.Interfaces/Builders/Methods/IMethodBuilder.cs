using KappaESB.Classes;
using KappaESB.Classes.Common;
using KappaESB.Classes.Requests;
using KappaESB.Interfaces.Builders.Endpoints;

namespace KappaESB.Interfaces.Builders.Methods
{
    public interface IMethodBuilder
    {
        /// <summary>
        /// Method version. Used to make correct http route and support old APIs. Default value - 1.
        /// </summary>
        /// <param name="versionNumber"></param>
        /// <returns></returns>
        IMethodBuilder Version(int versionNumber);
        /// <summary>
        /// Delivery mode. Use it for reliable delivery. Default value - TwoWayTransient.
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        IMethodBuilder DeliveryMode(DeliveryMode mode);
        /// <summary>
        /// Start configuring endpoints
        /// </summary>
        /// <returns></returns>
        IEndpointBuilder<TransferInfo> Begin();
        /// <summary>
        /// Start configuring endpoints with incoming data
        /// </summary>
        /// <typeparam name="Request">Type of request body</typeparam>
        /// <returns></returns>
        IEndpointBuilder<Request> Begin<Request>() where Request : class;
        /// <summary>
        /// HTTP type of method
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        IMethodBuilder MethodType(RequestType type);
        /// <summary>
        /// Type of request that we are using to serialize request body. Sealed and can't be overriden. All logic must be implemented in RequestDtoType(Type type)
        /// </summary>
        /// <typeparam name="RequestType"></typeparam>
        /// <returns></returns>
        sealed IMethodBuilder RequestDtoType<RequestType>() where RequestType : class
        {
            return RequestDtoType(typeof(RequestType));
        }
        /// <summary>
        /// Type of request that we are using to serialize request body
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        IMethodBuilder RequestDtoType(Type type);
        /// <summary>
        /// Type of response. Sealed and can't be overriden. All logic must be implemented in ResponseDtoType(Type type)
        /// </summary>
        /// <typeparam name="ResponseType"></typeparam>
        /// <returns></returns>
        sealed IMethodBuilder ResponseDtoType<ResponseType>() where ResponseType : class
        {
            return RequestDtoType(typeof(ResponseType));
        }
        /// <summary>
        /// Type of response
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        IMethodBuilder ResponseDtoType(Type type);
    }
}
