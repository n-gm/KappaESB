using KappaESB.Core.Interfaces;
using KappaESB.Interfaces.Builders.Controllers;

namespace KappaESB.Core.Config
{
    internal class EsbConfig : IEsbConfig
    {
        private IControllerBuilder _controllerBuilder;
        public QueueType BusQueueType { get; set; }
        public string? QueueConnectionString { get; set; }

        public IEsbConfig AddRouteConfiguration<ConfigurationType>() where ConfigurationType : IRouteConfiguration, new()
        {
            var config = new ConfigurationType();
            return AddRouteConfiguration(config);
        }

        public IEsbConfig AddRouteConfiguration(IRouteConfiguration config)
        {
            config.Configure(_controllerBuilder);
            return this;
        }

        public IEsbConfig AddRouteConfiguration(Action<IControllerBuilder> builder)
        {
            builder?.Invoke(_controllerBuilder);
            return this;
        }
    }
}
