using RestAPI.Application.DataTransferObjects;
using RestAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Application.Mappers.Interfaces
{
    public interface IMapperProduct : IMapper<ProductDTO, Product> { }
}
