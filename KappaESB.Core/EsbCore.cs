using KappaESB.Classes;
using KappaESB.Core.Methods;
using KappaESB.Core.Controllers;
using KappaESB.Core.Endpoints;
using KappaESB.Core.Methods;
using System.Collections.Concurrent;

namespace KappaESB.Core
{
    internal class EsbCore
    {
        private Dictionary<string, EsbController> _controllers;
        private Dictionary<string, EsbMethod> _methods;
        private Dictionary<string, EsbEndpoint> _endpoints;
        private ConcurrentDictionary<Guid, EsbMethodRoute> _routes;

        public EsbCore()
        {
            _controllers = new Dictionary<string, EsbController>();
            _methods = new Dictionary<string, EsbMethod>();
            _endpoints = new Dictionary<string, EsbEndpoint>();
            _routes = new ConcurrentDictionary<Guid, EsbMethodRoute>();
        }

        public async Task ProcessMessageAsync(object message)
        {
            if (message is TransferInfo info)
            {
                await ProcessMessageAsync(info);
            } else
            {
                throw new Exception("Message from endpoint is not TransferInfo type");
            }
        }

        public async Task ProcessMessageAsync(TransferInfo message)
        {

        }

        public async Task ProcessMessageAsync<T>(Transfer<T> message) where T:class
        {

        }
    }
}
