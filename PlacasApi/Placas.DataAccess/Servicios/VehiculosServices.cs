using Placas.Entities.Domain;
using Placas.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.DataAccess.Servicios
{
    public class VehiculosServices : IVehiculos
    {
        public IRepository<Vehiculos> _repository { get; set; }
        public VehiculosServices(IRepository<Vehiculos> repository)
        {
            _repository = repository;
        }
        public void ActualizarVehiculos(int Id,Vehiculos vehiculos)
        {
            vehiculos.IdVehiculos = Id;
            _repository.Update(Id, vehiculos);
        }

        public void AgregarVehiculo(Vehiculos vehiculos)
        {
             _repository.Add(vehiculos);
        }

        public void EliminarVehiculo(int Id)
        {
            var item = _repository.GetById(Id);
            _repository.Delete(item);
        }

        public IEnumerable<Vehiculos> GetAllVehiculos()
        {
            return _repository.GetAll("TipoVehiculos");
        }

        public Vehiculos GetVehiculoById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
