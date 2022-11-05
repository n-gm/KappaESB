using KappaESB.Classes.Exceptions;
using KappaESB.Interfaces.Builders.Controllers;
using KappaESB.Interfaces.Builders.Methods;

namespace KappaESB.Core.Builders
{
    internal class ControllerBuilder : IControllerBuilder
    {
        private Dictionary<string, MethodBuilder> _methodBuilders = new();
        public string Name { get; set; }

        public string Description { get; set; }

        public ControllerBuilder(string name, string description)
        {
            Name = name;
            Description = description ?? string.Empty; 
        }

        public IMethodBuilder DeclareMethod(string methodName, string methodDescription = "", int version = 1)
        {
            if (_methodBuilders.TryGetValue(FormatKey(methodName, version), out var _))
            {
                throw new MethodAlreadyDeclaredException(methodName, version);
            } else
            {
                var builder = new MethodBuilder(methodName, methodDescription, version);
                _methodBuilders.Add(FormatKey(methodName, version), builder);
                return builder;
            }
        }

        private string FormatKey(string methodName, int version)
        {
            return $"{version}/{methodName}";
        }
    }
}
