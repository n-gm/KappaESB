using KappaESB.Classes.Common;

namespace KappaESB.Endpoints
{
    public class EndpointSettings
    {
        public QueueType QueueType { get; set; } = QueueType.KappaMQ;
        public string QueueConnectionString { get; set; }
    }
}
