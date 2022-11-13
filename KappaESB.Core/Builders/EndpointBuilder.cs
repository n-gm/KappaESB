using KappaESB.Classes;
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
        public string Name { get; private set; }
        public string Description { get; private set; }
        public Func<Transfer<Request>, object> Processor { get; set; }        
        public EndpointBuilderBase Next { get; private set; }

        public EndpointBuilder() {
        }

        public override object Perform(TransferInfo request)
        {
            if (!(request is Transfer<Request> typedRequest))
            {

            }

            switch (EndpointType)
            {
                case EndpointType.Processor:
                case EndpointType.Convertor:
                    return Processor?.Invoke(typedRequest);
            }
        }

        public IEndpointBuilder<Response> Convert<Response>(Func<Transfer<Request>, Response> func) where Response : class
        {
            EndpointType = EndpointType.Convertor;
            Processor = func;
            var result = new EndpointBuilder<Response>();
            Next = result;
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
