using RestAPI.Application.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Application.Interfaces
{
    public interface IApplicationServiceProduct
    {
        void Add(ProductDTO entity);
        void Update(ProductDTO entity);
        void Delete(ProductDTO entity);
        IEnumerable<ProductDTO> GetAll();
        ProductDTO GetById(int id);
    }
}
