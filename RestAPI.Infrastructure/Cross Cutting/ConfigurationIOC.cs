using Autofac;
using RestAPI.Application;
using RestAPI.Application.Interfaces;
using RestAPI.Application.Mappers;
using RestAPI.Application.Mappers.Interfaces;
using RestAPI.Domain.Generics;
using RestAPI.Domain.Generics.Services;
using RestAPI.Domain.Services;
using RestAPI.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Infrastructure.Cross_Cutting
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<ApplicationServiceClient>().As<IApplicationServiceClient>();
            containerBuilder.RegisterType<ApplicationServiceProduct>().As<IApplicationServiceProduct>();

            containerBuilder.RegisterType<ServiceClient>().As<IServiceClient>();
            containerBuilder.RegisterType<ServiceProduct>().As<IServiceProduct>();

            containerBuilder.RegisterType<ClientRepository>().As<IClientRepository>();
            containerBuilder.RegisterType<ProductRepository>().As<IProductRepository>();

            containerBuilder.RegisterType<MapperClient>().As<IMapperClient>();
            containerBuilder.RegisterType<MapperProduct>().As<IMapperProduct>();
        }
    }
}
