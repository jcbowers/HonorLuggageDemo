using HonorLuggage.Domain.Core;
using HonorLuggage.Domain.Services.Repositories;
using System.Collections.Generic;

namespace HonorLuggage.Domain.Data
{
    public class GenericRepository<T> : IRepository<T> where T : Entity
    {
        private Dictionary<string, T> _entities = new Dictionary<string, T>();

        public T Get(string Id)
        {
            return _entities[Id];
        }

        public void Save(T entity)
        {
            _entities[entity.Id] = entity;
        }
    }
}
