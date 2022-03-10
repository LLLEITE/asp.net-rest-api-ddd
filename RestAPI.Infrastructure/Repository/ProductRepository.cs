using RestAPI.Domain.Entities;
using RestAPI.Domain.Generics;
using RestAPI.Infrastructure.Configuration;
using RestAPI.Infrastructure.Repository.Generics;

namespace RestAPI.Infrastructure.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository 
    {
        private readonly SqlContext contextBase;

        public ProductRepository(SqlContext contextBase) : base(contextBase)
        {
            this.contextBase = contextBase;
        }
    }
}
