using RestAPI.Application.DataTransferObjects;
using RestAPI.Application.Interfaces;
using RestAPI.Application.Mappers.Interfaces;
using RestAPI.Domain.Generics.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Application
{
    public class ApplicationServiceProduct : IApplicationServiceProduct
    {
        private readonly IServiceProduct serviceProduct;
        private readonly IMapperProduct mapperProduct;

        public ApplicationServiceProduct(IServiceProduct serviceProduct, IMapperProduct mapperProduct)
        {
            this.serviceProduct = serviceProduct;
            this.mapperProduct = mapperProduct;
        }

        public void Add(ProductDTO productDTO)
        {
            var product = mapperProduct.MapperDTOToEntity(productDTO);

            serviceProduct.Add(product);
        }

        public IEnumerable<ProductDTO> GetAll()
        {
            var product = serviceProduct.GetAll();

            return mapperProduct.MapperDTOToList(product);
        }

        public ProductDTO GetById(int id)
        {
            var product = serviceProduct.GetById(id);

            return mapperProduct.MapperEntityToDTO(product);
        }

        public void Delete(ProductDTO productDTO)
        {
            var product = mapperProduct.MapperDTOToEntity(productDTO);

            serviceProduct.Delete(product);
        }

        public void Update(ProductDTO productDTO)
        {
            var product = mapperProduct.MapperDTOToEntity(productDTO);

            serviceProduct.Update(product);
        }
    }
}
