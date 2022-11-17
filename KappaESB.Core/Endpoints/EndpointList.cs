using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KappaESB.Core.Endpoints
{
    internal class EndpointList
    {
        private List<string> _endpoints;

        public EndpointList()
        {
            _endpoints = new List<string>();
        }

        public string this[int index]
        {
            get { return _endpoints[index]; }
        }

        public void Assert(string endpointName)
        {
            _endpoints.Add(endpointName);
        }

        public string First()
        {
            return _endpoints[0];
        }
    }
}
