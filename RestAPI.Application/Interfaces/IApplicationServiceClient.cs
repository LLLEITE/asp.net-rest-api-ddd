using RestAPI.Application.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestAPI.Application.Interfaces
{
    public interface IApplicationServiceClient
    {
        void Add(ClientDTO entity);
        void Update(ClientDTO entity);
        void Delete(ClientDTO entity);
        IEnumerable<ClientDTO> GetAll();
        ClientDTO GetById(int id);
    }
}
