using KappaESB.Classes.Requests;
using Microsoft.AspNetCore.Http;

namespace KappaESB.AspNetCore.Delegates
{
    internal class EsbDelegate<RequestBody> where RequestBody : class
    {
        /// <summary>
        /// Controller name
        /// </summary>
        public string ControllerName { get; private set; }
        /// <summary>
        /// Method name
        /// </summary>
        public string MethodName { get; private set; }
        /// <summary>
        /// Method's version. System can support different versions of method.
        /// </summary>
        public int Version { get; private set; }
        /// <summary>
        /// Http path to method
        /// </summary>
        public string Path => $"/{ControllerName}/{Version}/{MethodName}";
        /// <summary>
        /// Request type
        /// </summary>
        public RequestType RequestType { get; set; }
        /// <summary>
        /// Request Content-Type. If actual content-type is not equal to this we'll return 415 code
        /// </summary>
        public string? RequestContentType { get; set; }
        public string? ResponseContentType { get; set; }

        public EsbDelegate(string controllerName, string methodName, int version)
        {
            ControllerName = controllerName;
            MethodName = methodName;
            Version = version;
        }

        /// <summary>
        /// Main method processor. Make all preparation and send initial data to bus.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task RequestDelegate(HttpContext context)
        {
            //If Request Content-Type do not equals to content-type from config return 415
            if (!string.IsNullOrWhiteSpace(RequestContentType) && !CheckRequestContentType(context.Request.ContentType ?? ""))
            {
                context.Response.Clear();
                context.Response.StatusCode = 415;
            }
        }

        #region Private
        private bool CheckRequestContentType(string requestContentType)
        {
            return requestContentType.Equals(RequestContentType, StringComparison.OrdinalIgnoreCase);
        }
        #endregion
    }
}
