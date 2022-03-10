using RestAPI.Application.DataTransferObjects;
using RestAPI.Application.Mappers.Interfaces;
using RestAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestAPI.Application.Mappers
{
    public class MapperProduct : IMapperProduct
    {
        public Product MapperDTOToEntity(ProductDTO productDTO)
        {
            var product = new Product()
            {
                Id = productDTO.Id,
                Name = productDTO.Name,
                Value = productDTO.Value,
            };

            return product;
        }

        public ProductDTO MapperEntityToDTO(Product product)
        {
            var productDTO = new ProductDTO()
            {
                Id = product.Id,
                Name = product.Name,
                Value = product.Value,
            };

            return productDTO;
        }

        public IEnumerable<ProductDTO> MapperDTOToList(IEnumerable<Product> products)
        {
            var dto = products.Select(product => new ProductDTO { Id = product.Id, Name = product.Name, Value = product.Value });

            return dto;
        }
    }
}
