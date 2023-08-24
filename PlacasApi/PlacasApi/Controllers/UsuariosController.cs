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
    public class UsuariosController : ControllerBase
    {

        public IUsuarios _IUsuario;
        private readonly IMapper _mapper;

        public UsuariosController(IUsuarios iUsuario, IMapper mapper)
        {
            _IUsuario = iUsuario;
            _mapper = mapper;
        }


        // GET: api/<UsuariosController>
        [HttpGet]
        public IEnumerable<Usuarios> Get()
        {
            return _IUsuario.GetAllUsuarios();
        }

        // GET api/<UsuariosController>/5
        [HttpGet("{id}")]
        public Usuarios Get(int id)
        {
            return _IUsuario.GetUsuarioById(id);
        }

        // POST api/<UsuariosController>
        [HttpPost]
        public void Post([FromBody] UsuariosDto Data)
        {
            var _Usuario = _mapper.Map<Usuarios>(Data);
            _IUsuario.AgregarUsuario(_Usuario);
        }

        // PUT api/<UsuariosController>/5
        [HttpPut("{id}")]
        public void Put(int Id, [FromBody] UsuariosDto value)
        {
            var _Usuario = _mapper.Map<Usuarios>(value);
            _IUsuario.ActualizarUsuario(Id,_Usuario);
        }

        // DELETE api/<UsuariosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _IUsuario.EliminarUsuario(id);
        }
    }
}
