using KappaESB.Classes.Common;
using KappaESB.Classes.Requests;
using KappaESB.Interfaces.Builders.Endpoints;
using KappaESB.Interfaces.Builders.Methods;

namespace KappaESB.Core.Builders
{
    internal class MethodBuilder : IMethodBuilder
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Version { get; private set; }

        public MethodBuilder(string name, string description, int version)
        {
            Name = name;
            Description = description ?? string.Empty;
            Version = version;
        }

        public IEndpointBuilder<EmptyRequest> Begin()
        {
            throw new NotImplementedException();
        }

        public IEndpointBuilder<Request> Begin<Request>() where Request : class
        {
            throw new NotImplementedException();
        }

        public IMethodBuilder DeliveryMode(DeliveryMode mode)
        {
            throw new NotImplementedException();
        }

        public IMethodBuilder ExpectQueryParameter(string parameterName)
        {
            throw new NotImplementedException();
        }

        public IMethodBuilder MethodType(RequestType type)
        {
            throw new NotImplementedException();
        }

        public IMethodBuilder RequestDtoType(Type type)
        {
            throw new NotImplementedException();
        }

        public IMethodBuilder ResponseContentType(string contentType)
        {
            throw new NotImplementedException();
        }

        public IMethodBuilder ResponseDtoType(Type type)
        {
            throw new NotImplementedException();
        }

        public IMethodBuilder RestrictRequestContentType(string contentType)
        {
            throw new NotImplementedException();
        }
    }
}
