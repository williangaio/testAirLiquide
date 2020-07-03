using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AirTest.Domain.Services.Interfaces;
using AirTest.Domain.Entities;

namespace AirTest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        IClienteService _clienteService;
        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            try
            {
                IEnumerable<Cliente> cliente = _clienteService.AllClientes();
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Cliente> Get(Guid id)
        {
            try
            {
                Cliente cliente = _clienteService.GetCliente(id);
                return cliente;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Cliente cliente)
        {
            try
            {
                _clienteService.AddCliente(cliente);
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Cliente cliente)
        {
            try
            {
                Cliente cliUpdate = _clienteService.GetCliente(id);
                cliUpdate.Idade = cliente.Idade;
                cliUpdate.Nome = cliente.Nome;
                _clienteService.updateCliente(cliUpdate);
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            try
            {
                _clienteService.deleteCliente(id);
            }
            catch (Exception ex)
            {
                BadRequest(ex.Message);
            }
        }
    }
}
