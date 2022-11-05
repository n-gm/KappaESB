using KappaESB.Classes;

namespace KappaESB.Core.Interfaces
{
    public interface IEsbCore
    {
        static IEsbCore Create() => new EsbCore();
        Task ProcessMessageAsync(object message);
        Task ProcessMessageAsync(TransferInfo message);
        Task ProcessMessageAsync<T>(Transfer<T> message) where T : class;
    }
}
