using HonorsLuggage.Domain.Core;

namespace HonorsLuggage.Domain.Services.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        T Get(string Id);
        void Save(T entity);
    }
}
