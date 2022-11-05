namespace KappaESB.Classes.Requests
{
    /// <summary>
    /// Информация по запросу
    /// </summary>
    public class RequestData
    {
        /// <summary>
        /// Тип запроса
        /// </summary>
        public RequestType RequestType { get; set; }
        /// <summary>
        /// Параметры, передаваемые в строке адреса
        /// </summary>
        public List<KeyValuePair<string,string>> Params { get; set; } = new List<KeyValuePair<string, string>>();        
    }
}
