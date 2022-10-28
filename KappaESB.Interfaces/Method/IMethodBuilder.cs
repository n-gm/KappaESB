using KappaESB.Classes;
using KappaESB.Classes.Requests;
using KappaESB.Interfaces.Endpoint;

namespace KappaESB.Interfaces.Method
{
    public interface IMethodBuilder
    {
        /// <summary>
        /// Start configuring endpoints
        /// </summary>
        /// <returns></returns>
        IEndpointBuilder<Transfer> Begin();
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
