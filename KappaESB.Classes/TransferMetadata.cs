namespace KappaESB.Classes
{
    public class TransferMetadata
    {
        /// <summary>
        /// Value used to make two-way queue
        /// </summary>
        public string CorrelationId { get; set; }
        /// <summary>
        /// Current retry count. Increases each time message was declined and set to 0 after successfull processing
        /// </summary>
        public int RetryCount { get; set; } = 0;
        /// <summary>
        /// Max retry count before message have to be deleted. -1 - infinite retry count, 0 - no retries.
        /// </summary>
        public int MaxRetryCount { get; set; } = -1;
    }
}
