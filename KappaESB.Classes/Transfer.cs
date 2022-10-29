namespace KappaESB.Classes
{
    public class Transfer<T>:TransferInfo where T : class
    {        
        public T Response { get; set; }
    }
}
