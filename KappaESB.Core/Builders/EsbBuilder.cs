using KappaESB.Interfaces.Builders.Controllers;
using KappaESB.Interfaces.Builders.Core;

namespace KappaESB.Core.Builders
{
    internal class EsbBuilder : IEsbBuilder
    {
        private Dictionary<string, ControllerBuilder> _controllerBuilders = new();
        public IControllerBuilder DeclareController(string controllerName, string controllerDescription = "")
        {
            if (_controllerBuilders.TryGetValue(controllerName, out var builder))
            {
                return builder;
            } else
            {
                _controllerBuilders.Add(controllerName, builder = new ControllerBuilder(controllerName, controllerDescription));
                return builder;
            }
        }
    }
}
