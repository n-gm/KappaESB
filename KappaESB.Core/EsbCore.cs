using KappaESB.MainBuilder.Controllers;
using KappaESB.MainBuilder.Endpoints;
using KappaESB.MainBuilder.Methods;

namespace KappaESB.MainBuilder
{
    internal class EsbCore
    {
        private Dictionary<string, EsbController> _controllers;
        private Dictionary<string, EsbMethod> _methods;
        private Dictionary<string, EsbEndpoint> _endpoints;

        public EsbCore()
        {
            _controllers = new Dictionary<string, EsbController>();
            _methods = new Dictionary<string, EsbMethod>();
            _endpoints = new Dictionary<string, EsbEndpoint>();
        }
    }
}
