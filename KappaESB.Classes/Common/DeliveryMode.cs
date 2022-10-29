namespace KappaESB.Classes.Common
{
    public enum DeliveryMode
    {
        /// <summary>
        /// Message stored to disk and return Http.Ok. Message will be delivered even after reboot.
        /// </summary>
        OneWay,
        /// <summary>
        /// Message stored to disk. Message will be delivered even after reboot.
        /// </summary>
        PersistentTwoWay,
        /// <summary>
        /// Message don't stored to disk. Use it for getting info. 
        /// </summary>
        TransientTwoWay
    }
}
