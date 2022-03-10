using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Domain.Generics
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
    }
}