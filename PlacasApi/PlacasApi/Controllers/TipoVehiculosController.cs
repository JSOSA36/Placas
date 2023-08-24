using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Placas.Entities.Domain;
using Placas.Entities.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlacasApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoVehiculosController : ControllerBase
    {

        public ITipoVehiculos _ITipoVehiculos;
        private readonly IMapper _mapper;


        public TipoVehiculosController(ITipoVehiculos iTipoVehiculos, IMapper mapper)
        {
            _ITipoVehiculos = iTipoVehiculos;
            _mapper = mapper;
        }



        // GET: api/<TipoVehiculosController>
        [HttpGet]
        public IEnumerable<TipoVehiculos> Get()
        {
            return _ITipoVehiculos.GetAllTipoTipoVehiculos();
        }

       
        
    }
}
