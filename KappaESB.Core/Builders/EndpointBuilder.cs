using KappaESB.Classes;
using KappaESB.Core.Endpoints;
using KappaESB.Interfaces.Builders.Endpoints;
using KappaESB.Interfaces.Processors;

namespace KappaESB.Core.Builders
{
    internal enum EndpointType
    {
        Undefined,
        Processor,
        Convertor,
        Condition
    }

    internal class EndpointBuilder<Request> : EndpointBuilderBase, IEndpointBuilder<Request> where Request : class
    {
        private readonly EndpointList _endpoints;

        public EndpointBuilder(EndpointList endpoints) {
            _endpoints = endpoints;
        }

        public IEndpointBuilder<Response> Convert<Response>(Func<Transfer<Request>, Response> func) where Response : class
        {
            EndpointType = EndpointType.Convertor;
            var result = new EndpointBuilder<Response>(_endpoints);
            return result;
        }

        public IEndpointBuilder<Response> Do<Response>(string endpointName, Func<Transfer<Request>, Response> func) where Response : class
        {
            throw new NotImplementedException();
        }

        public IEndpointBuilder<Response> DoAsync<Response>(string endpointName, Func<Transfer<Request>, Task<Response>> func) where Response : class
        {
            throw new NotImplementedException();
        }

        public IEndpointBuilder<Request> Else()
        {
            throw new NotImplementedException();
        }

        public IEndpointBuilder<Request> ElseIf(Func<Request, bool> condition)
        {
            throw new NotImplementedException();
        }

        public IEndpointBuilder<Request> EndIf()
        {
            throw new NotImplementedException();
        }

        public IEndpointBuilder<Request> If(Func<Request, bool> condition)
        {
            throw new NotImplementedException();
        }

        public IEndpointBuilder<Response> RouteToEndpoint<Response>(string endpointName) where Response : class
        {
            throw new NotImplementedException();
        }

        public IEndpointBuilder<Response> UseAsyncEndpoint<Response, Endpoint>(bool isLocal = true)
            where Response : class
            where Endpoint : IAsyncEndpoint<Request, Response>, new()
        {
            throw new NotImplementedException();
        }

        public IEndpointBuilder<Response> UseEndpoint<Response, Endpoint>(bool isLocal = true)
            where Response : class
            where Endpoint : ISyncEndpoint<Request, Response>, new()
        {
            throw new NotImplementedException();
        }
    }
}
