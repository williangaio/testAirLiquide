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
                //todo: log
                return BadRequest(ex.Message);
            }
        }
        
        [HttpGet("{id}")]
        public ActionResult<Cliente> Get(string id)
        {
            try
            {
                Guid guid = Guid.Parse(id);
                Cliente cliente = _clienteService.GetCliente(guid);
                return cliente;
            }
            catch (Exception ex)
            {
                //todo: log
                return BadRequest(ex.Message);
            }
        }
        
        [HttpPost]
        public void Post([FromBody] Cliente cliente)
        {
            try
            {
                cliente.Id = Guid.NewGuid();
                _clienteService.AddCliente(cliente);
            }
            catch (Exception ex)
            {
                //todo: log
                BadRequest(ex.Message);
            }
        }
        
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Cliente cliente)
        {
            try
            {
                Guid guid = Guid.Parse(id);
                Cliente cliUpdate = _clienteService.GetCliente(guid);
                cliUpdate.Idade = cliente.Idade;
                cliUpdate.Nome = cliente.Nome;
                _clienteService.updateCliente(cliUpdate);
            }
            catch (Exception ex)
            {
                //todo: log
                BadRequest(ex.Message);
            }
        }
        
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            try
            {
                Guid guid = Guid.Parse(id);
                _clienteService.deleteCliente(guid);
            }
            catch (Exception ex)
            {
                //todo: log
                BadRequest(ex.Message);
            }
        }
    }
}
