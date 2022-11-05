namespace KappaESB.Classes.Requests
{
    /// <summary>
    /// Request data
    /// </summary>
    public class RequestData
    {
        /// <summary>
        /// Request type
        /// </summary>
        public RequestType RequestType { get; set; }
        /// <summary>
        /// Request parameters from query
        /// </summary>
        public List<KeyValuePair<string,string>> Params { get; set; } = new List<KeyValuePair<string, string>>();        
    }
}
