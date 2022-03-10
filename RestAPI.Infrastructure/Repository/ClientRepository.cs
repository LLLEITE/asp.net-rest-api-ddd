using RestAPI.Domain.Entities;
using RestAPI.Domain.Generics;
using RestAPI.Infrastructure.Configuration;
using RestAPI.Infrastructure.Repository.Generics;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Infrastructure.Repository
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository 
    {
        private readonly SqlContext contextBase;
        
        public ClientRepository(SqlContext contextBase): base(contextBase)
        {
            this.contextBase = contextBase;
        }
    }
}
