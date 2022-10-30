namespace KappaESB.Core.Config
{
    public class EsbConfig
    {
        /// <summary>
        /// Type of queue that is used to provide connection between endpoints
        /// </summary>
        public QueueType BusQueueType { get; set; }
        /// <summary>
        /// Connection string to connect to queue. Not used for internal queue
        /// </summary>
        public string? QueueConnectionString { get; set; }
    }
}
