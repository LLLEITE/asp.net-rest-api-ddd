using RestAPI.Application.DataTransferObjects;
using RestAPI.Application.Interfaces;
using RestAPI.Application.Mappers.Interfaces;
using RestAPI.Domain.Generics.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RestAPI.Domain.Entities;

namespace RestAPI.Application
{
    public class ApplicationServiceClient : IApplicationServiceClient
    {
        private readonly IServiceClient serviceClient;
        private readonly IMapperClient mapperClient;

        public ApplicationServiceClient(IServiceClient serviceClient, IMapperClient mapperClient)
        {
            this.serviceClient = serviceClient;
            this.mapperClient = mapperClient;
        }

        public void Add(ClientDTO clientDTO)
        {
            var client = mapperClient.MapperDTOToEntity(clientDTO);

            serviceClient.Add(client);
        }

        public void Delete(ClientDTO clientDTO)
        {
            var client = mapperClient.MapperDTOToEntity(clientDTO);

            serviceClient.Delete(client);
        }

        public IEnumerable<ClientDTO> GetAll()
        {
            var clients = serviceClient.GetAll();

            return mapperClient.MapperDTOToList(clients);
        }

        public ClientDTO GetById(int id)
        {
            var client = serviceClient.GetById(id);

            return mapperClient.MapperEntityToDTO(client);
        }

        public void Update(ClientDTO clientDTO)
        {
            var client = mapperClient.MapperDTOToEntity(clientDTO);

            serviceClient.Update(client);
        }
    }
}
