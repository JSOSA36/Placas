using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Placas.Entities.Domain;
using Placas.Entities.Dto;
using Placas.Entities.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlacasApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {


        public IClientes _IClientes;
        private readonly IMapper _mapper;

        public ClientesController(IClientes iClientes, IMapper mapper)
        {
            _IClientes = iClientes;
            _mapper = mapper;
        }
        // GET: api/<ClientesController>
        [HttpGet]
        public IEnumerable<Clientes> Get()
        {
            return _IClientes.GetAllClientes(); 
        }

        // GET api/<ClientesController>/5
        [HttpGet("{id}")]
        public Clientes Get(int id)
        {
            return _IClientes.GetClienteById(id);
        }

        // POST api/<ClientesController>
        [HttpPost]
        public void Post([FromBody] ClientesDto Data)
        {
            var _Cliente = _mapper.Map<Clientes>(Data);
            _IClientes.AgregarCliente(_Cliente);
        }

        // PUT api/<ClientesController>/5
        [HttpPut("{id}")]
        public void Put( [FromBody] ClientesDto value)
        {    
            var _Cliente= _mapper.Map<Clientes>(value);
            _IClientes.AgregarCliente(_Cliente);
        }

        // DELETE api/<ClientesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _IClientes.EliminarCliente(id);
        }
    }
}
