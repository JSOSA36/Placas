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
    public class VehiculoController : ControllerBase
    {

        IVehiculos _IVehiculo;
        IMapper _Mapper;

        public VehiculoController(IVehiculos iVehiculo, IMapper mapper)
        {
            _IVehiculo = iVehiculo;
            _Mapper = mapper;
        }


        // GET: api/<VehiculoController>
        [HttpGet]
        public IEnumerable<Vehiculos> Get()
        {
            return _IVehiculo.GetAllVehiculos();
        }

        // GET api/<VehiculoController>/5
        [HttpGet("{id}")]
        public Vehiculos Get(int id)
        {
            return _IVehiculo.GetVehiculoById(id);
        }

        // POST api/<VehiculoController>
        [HttpPost]
        public void Post([FromBody] VehiculosDto value)
        {
            var _Vehiculo = _Mapper.Map<Vehiculos>(value);
            
            _IVehiculo.AgregarVehiculo(_Vehiculo);
        }

        // PUT api/<VehiculoController>/5
        [HttpPut("{id}")]
        public void Put(int Id, [FromBody] VehiculosDto value)
        {
            var _Vehiculo = _Mapper.Map<Vehiculos>(value);
            _IVehiculo.ActualizarVehiculos(Id,_Vehiculo);
        }

        // DELETE api/<VehiculoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _IVehiculo.EliminarVehiculo(id);
        }
    }
}
