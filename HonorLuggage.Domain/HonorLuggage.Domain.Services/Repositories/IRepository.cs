using HonorLuggage.Domain.Core;

namespace HonorLuggage.Domain.Services.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        T Get(string Id);
        void Save(T entity);
    }
}
