using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPI.Application.DataTransferObjects;
using RestAPI.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace RestAPI.API.Controllers
{
    [Route("api/client")]
    [ApiController]
    public class ClientsController : Controller
    {
        private readonly IApplicationServiceClient applicationServiceClient;

        public ClientsController(IApplicationServiceClient applicationServiceClient)
        {
            this.applicationServiceClient = applicationServiceClient; ;
        }


        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<String>> Get()
        {
            return Ok(applicationServiceClient.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceClient.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ClientDTO clientDTO)
        {
            try
            {
                if (clientDTO == null)
                    return NotFound();

                applicationServiceClient.Add(clientDTO);
                return Ok("Client successfully registered!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ClientDTO clientDTO)
        {
            try
            {
                if (clientDTO == null)
                    return NotFound();

                applicationServiceClient.Update(clientDTO);
                return Ok("Client successfully updated!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        // DELETE api/value/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ClientDTO clientDTO)
        {
            try
            {
                if (clientDTO == null)
                    return NotFound();

                applicationServiceClient.Delete(clientDTO);
                return Ok("Client successfully removed!");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
