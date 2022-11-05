using KappaESB.Core.Builders;
using KappaESB.Core.Interfaces;
using KappaESB.Interfaces.Builders.Core;

namespace KappaESB.Core.Config
{
    internal class EsbConfig : IEsbConfig
    {
        private IEsbBuilder _esb = new EsbBuilder();
        public QueueType BusQueueType { get; set; }
        public string? QueueConnectionString { get; set; }

        public IEsbConfig AddRouteConfiguration<ConfigurationType>() where ConfigurationType : IRouteConfiguration, new()
        {
            var config = new ConfigurationType();
            return AddRouteConfiguration(config);
        }

        public IEsbConfig AddRouteConfiguration(IRouteConfiguration config)
        {
            config.Configure(_esb);
            return this;
        }

        public IEsbConfig AddRouteConfiguration(Action<IEsbBuilder> builder)
        {
            builder?.Invoke(_esb);
            return this;
        }
    }
}
