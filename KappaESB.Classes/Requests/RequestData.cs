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
        public string[] Params { get; set; }
        /// <summary>
        /// Параметры, передаваемые в теле запроса
        /// </summary>
        public object DTO { get; set; }
    }
}
