using RestAPI.Domain.Entities;
using RestAPI.Domain.Generics;
using RestAPI.Domain.Generics.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Domain.Services
{
    public class ServiceProduct : ServiceBase<Product>, IServiceProduct
    {
        private readonly IProductRepository productRepository;

        public ServiceProduct(IProductRepository productRepository): base(productRepository)
        {
            this.productRepository = productRepository;
        }   
    }
}
