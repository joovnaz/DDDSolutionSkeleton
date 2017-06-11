namespace Domain.Common
{
    public interface IRepository<T>
    {
        T GetById(long Id);

        void Save(T aggregateRoot);

    }
}
