using KappaESB.Classes.Common;
using KappaESB.Classes.Requests;
using KappaESB.Core.Endpoints;
using KappaESB.Interfaces.Builders.Endpoints;
using KappaESB.Interfaces.Builders.Methods;

namespace KappaESB.Core.Builders
{
    internal class MethodBuilder : IMethodBuilder
    {
        public EndpointList Endpoints { get; private set; }
        public string RequestBodyContentType { get; private set; }
        public string ResponseBodyContentType { get; private set; }
        public Type RequestBodyType { get; private set; }
        public Type ResponseBodyType { get; private set; }
        public RequestType RequestType { get; private set; } = RequestType.GET;
        public List<string> Parameters { get; }
        public DeliveryMode DeliveryMode { get; private set; } = DeliveryMode.TransientTwoWay;
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Version { get; private set; }

        public MethodBuilder(string name, string description, int version)
        {
            Parameters = new List<string>();
            Name = name;
            Description = description ?? string.Empty;
            Version = version;
            Endpoints = new();
        }

        public IEndpointBuilder<EmptyRequest> Begin()
        {
            throw new NotImplementedException();
        }

        public IEndpointBuilder<Request> Begin<Request>() where Request : class
        {
            throw new NotImplementedException();
        }

        public IMethodBuilder MethodDeliveryMode(DeliveryMode mode)
        {
            DeliveryMode = mode;
            return this;
        }

        public IMethodBuilder ExpectQueryParameter(string parameterName)
        {
            if (!Parameters.Contains(parameterName))
            {
                Parameters.Add(parameterName);
            }
            return this;
        }

        public IMethodBuilder MethodType(RequestType type)
        {
            RequestType = type;
            return this;
        }

        public IMethodBuilder RequestDtoType(Type type)
        {
            RequestBodyType = type;
            return this;
        }

        public IMethodBuilder ResponseContentType(string contentType)
        {
            ResponseBodyContentType = contentType;
            return this;
        }

        public IMethodBuilder ResponseDtoType(Type type)
        {
            ResponseBodyType = type;
            return this;
        }

        public IMethodBuilder RestrictRequestContentType(string contentType)
        {
            RequestBodyContentType = contentType;
            return this;
        }
    }
}
