using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPI.Application.DataTransferObjects;
using RestAPI.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace RestAPI.API.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IApplicationServiceProduct applicationServiceProduct;

        public ProductsController(IApplicationServiceProduct applicationServiceProduct)
        {
            this.applicationServiceProduct = applicationServiceProduct;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(applicationServiceProduct.GetAll());
        }

        // GET api/values/5\
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(applicationServiceProduct.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ProductDTO productDTO)
        {
            try
            {
                if (productDTO == null)
                    return NotFound();


                applicationServiceProduct.Add(productDTO);
                return Ok("O produto foi cadastrado com sucesso");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] ProductDTO productDTO)
        {

            try
            {
                if (productDTO == null)
                    return NotFound();

                applicationServiceProduct.Update(productDTO);
                return Ok("O produto foi atualizado com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // DELETE api/values/5
        [HttpDelete()]
        public ActionResult Delete([FromBody] ProductDTO productDTO)
        {
            try
            {
                if (productDTO == null)
                    return NotFound();

                applicationServiceProduct.Delete(productDTO);
                return Ok("O produto foi removido com sucesso!");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
