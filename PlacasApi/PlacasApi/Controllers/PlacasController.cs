using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Placas.Entities.Domain;
using Placas.Entities.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlacasApi.Controllers
{
   

   

    [Route("api/[controller]")]
    [ApiController]
    public class PlacasController : ControllerBase
    {

        public IPlacas _IPlacas;
        public IVehiculos _IVehiculo;
        private readonly IMapper _mapper;

        public PlacasController(IPlacas iPlacas, IMapper mapper, IVehiculos iVehiculo)
        {
            _IPlacas = iPlacas;
            _mapper = mapper;
            _IVehiculo = iVehiculo;
        }


        // GET: api/<PlacasController>
        [HttpGet]
        public IEnumerable<Placas.Entities.Domain.Placas> Get()
        {
            return _IPlacas.GetAllPlacas();
        }

        // GET api/<PlacasController>/5
        [HttpGet("{id}")]
        public Placas.Entities.Domain.Placas Get(int id)
        {
            return _IPlacas.GetPlacasById(id);
        }

        [HttpGet("{IdCliente}")]
        public IEnumerable<Placas.Entities.Domain.Placas> GetPlacasByClientes(int IdCliente)
        {
            return _IPlacas.GetPlacasByCliente(IdCliente);
        }

        // POST api/<PlacasController>
        [HttpPost]
        public void Post([FromBody] Placas.Entities.Dto.PlacasDto placas)
        {
            var _Placas= _mapper.Map<Placas.Entities.Domain.Placas>(placas);

            var Vehiculo = _IVehiculo.GetVehiculoById(placas.IdVehiculos);
            //placas.NumeroPlaca = _IPlacas.GenerarNumeroPlaca(Vehiculo);
            _IPlacas.AgregarPlacas(_Placas);
        }

        // PUT api/<PlacasController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Placas.Entities.Dto.PlacasDto placas)
        {
            var _Placas = _mapper.Map<Placas.Entities.Domain.Placas>(placas);
            _IPlacas.ActualizarPlacas(_Placas);
        }

        // DELETE api/<PlacasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _IPlacas.EliminarPlacas(id);
        }
    }
}
