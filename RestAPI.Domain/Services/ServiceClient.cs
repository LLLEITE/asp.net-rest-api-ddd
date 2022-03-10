using RestAPI.Domain.Entities;
using RestAPI.Domain.Generics;
using RestAPI.Domain.Generics.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Domain.Services
{
    public class ServiceClient : ServiceBase<Client>, IServiceClient
    {
        private readonly IClientRepository clientRepository;
        
        public ServiceClient(IClientRepository clientRepository) : base(clientRepository)
        {
            this.clientRepository = clientRepository;
        }
    }
}
