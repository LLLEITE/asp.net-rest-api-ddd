using Microsoft.EntityFrameworkCore;
using RestAPI.Domain.Generics;
using RestAPI.Infrastructure.Configuration;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Infrastructure.Repository.Generics
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly SqlContext sqlContext;

        public GenericRepository(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }

        public void Add(TEntity entity)
        {
            try
            {
                sqlContext.Set<TEntity>().Add(entity);
                sqlContext.SaveChanges();
            }
            catch (Exception) { throw; }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return sqlContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return sqlContext.Set<TEntity>().Find(id);
        }

        public void Delete(TEntity entity)
        {
            try
            {
                sqlContext.Set<TEntity>().Remove(entity);
                sqlContext.SaveChanges();
            }
            catch (Exception) { throw; }
        }

        public void Update(TEntity entity)
        {
            try
            {
                sqlContext.Entry(entity).State = EntityState.Modified;
                sqlContext.SaveChanges();
            }
            catch (Exception) { throw; }
        }
    }
}
