using KappaESB.Classes;

namespace KappaESB.Interfaces.Transport
{
    public enum DeclineActionType
    {
        ReturnToQueue,
        Delete,
        ReturnToEndOfQueue
    }

    public interface IClient<Request, Response> : IDisposable
        where Request : class
        where Response : class
    {
        string QueueName { get; }
        /// <summary>
        /// Connect to server
        /// </summary>
        void Connect(string connectionString);
        void Disconnect();
        /// <summary>
        /// Message received event. For push-based logic.
        /// </summary>
        Func<string, Transfer<Request>, Task> OnMessage { get; set; }
        /// <summary>
        /// Get next message in queue. For pull-based logic.
        /// </summary>
        /// <returns></returns>
        Transfer<Request> NextMessage();
        /// <summary>
        /// Message was processed successfully. Delete it from queue.
        /// </summary>
        /// <param name="messageId"></param>
        void Accept(string messageId);
        /// <summary>
        /// Message wasn't processed. Return message to queue.
        /// </summary>
        /// <param name="messageId"></param>
        void Decline(string messageId, DeclineActionType action = DeclineActionType.ReturnToQueue);
        /// <summary>
        /// Send response
        /// </summary>
        /// <param name="response"></param>
        void SendResponse(Transfer<Response> response);
    }
}
