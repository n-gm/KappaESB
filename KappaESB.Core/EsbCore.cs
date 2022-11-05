using KappaESB.Classes;
using KappaESB.Core.Controllers;
using KappaESB.Core.Interfaces;

namespace KappaESB.Core
{
    internal class EsbCore : IEsbCore
    {
        private Dictionary<string, EsbController> _controllers;

        public EsbCore()
        {
            _controllers = new Dictionary<string, EsbController>();
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
