using RestAPI.Application.DataTransferObjects;
using RestAPI.Application.Mappers.Interfaces;
using RestAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestAPI.Application.Mappers
{
    public class MapperClient : IMapperClient
    {
        public Client MapperDTOToEntity(ClientDTO clientDTO)
        {
            var client = new Client()
            {
                Id = clientDTO.Id,
                Name = clientDTO.Name,
                LastName = clientDTO.LastName,
                Email = clientDTO.Email,
            };

            return client;
        }

        public ClientDTO MapperEntityToDTO(Client client)
        {
            var clientDTO = new ClientDTO()
            {
                Id = client.Id,
                Name = client.Name,
                LastName = client.LastName,
                Email = client.Email,
            };

            return clientDTO;
        }

        public IEnumerable<ClientDTO> MapperDTOToList(IEnumerable<Client> clients)
        {
            var data = clients.Select(client => new ClientDTO { Id = client.Id, Name = client.Name, LastName = client.LastName, Email = client.Email });

            return data;
        }
    }
}
