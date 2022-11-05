using KappaESB.Classes;
using KappaESB.Classes.Common;
using KappaESB.Classes.Requests;
using KappaESB.Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;

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
            if (!string.IsNullOrWhiteSpace(RequestContentType) 
                && !CheckRequestContentType(context.Request.ContentType ?? ""))
            {
                ReturnError(context, 415);
                return;
            }

            var transfer = new Transfer<RequestBody>();

            //If information expected in request's body
            if (typeof(RequestBody) != typeof(EmptyRequest))
            {
                try
                {
                    var data = JsonSerializer.Deserialize<RequestBody>(context.Request.Body);
                } catch
                {
                    ReturnError(context, 400);
                    return;
                }
            }

            IEsbCore core = context.RequestServices.GetService<IEsbCore>()!;
            await core.ProcessMessageAsync(transfer);
        }

        #region Private
        private bool CheckRequestContentType(string requestContentType)
        {
            return requestContentType.Equals(RequestContentType, StringComparison.OrdinalIgnoreCase);
        }

        private void ReturnError(HttpContext context, int errorCode)
        {
            context.Response.Clear();
            context.Response.StatusCode = errorCode;            
        }
        #endregion
    }
}
