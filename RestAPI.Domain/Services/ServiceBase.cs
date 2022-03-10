using RestAPI.Domain.Generics;
using RestAPI.Domain.Generics.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Domain.Services
{
    public class ServiceBase<TEntity> : IGenericService<TEntity> where TEntity : class
    {
        private readonly IGenericRepository<TEntity> repository;

        public ServiceBase(IGenericRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public void Add(TEntity entity)
        {
            repository.Add(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return (IEnumerable<TEntity>) repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return repository.GetById(id) as TEntity;
        }

        public void Delete(TEntity entity)
        {
            repository.Delete(entity);
        }

        public void Update(TEntity entity)
        {
            repository.Update(entity);
        }
    }
}
