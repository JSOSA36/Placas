using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Placas.Entities.Domain;
using Placas.Entities.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlacasApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPersonasController : ControllerBase
    {

        public ITipoPersona _ITipoPersona;
        private readonly IMapper _mapper;

        public TipoPersonasController(ITipoPersona iTipoPersona, IMapper mapper)
        {
            _ITipoPersona = iTipoPersona;
            _mapper = mapper;
        }


        // GET: api/<TipoPersonasController>
        [HttpGet]
        public IEnumerable<TipoPersona> Get()
        {
            return _ITipoPersona.GetAllTipoPersona();
        }

        // GET api/<TipoPersonasController>/5
        
    }
}
