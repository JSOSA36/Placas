using Placas.Entities.Domain;
using Placas.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.DataAccess.Servicios
{
    public class TipoVehiculosServices : ITipoVehiculos
    {
        public IRepository<TipoVehiculos> _repository { get; set; }
        public TipoVehiculosServices(IRepository<TipoVehiculos> repository)
        {
            _repository = repository;
        }
        public void ActualizarTipoVehiculos(TipoVehiculos TipoVehiculos)
        {
            _repository.Update(TipoVehiculos.Id, TipoVehiculos);
        }

        public void AgregarTipoTipoVehiculos(TipoVehiculos TipoVehiculos)
        {
            _repository.Add(TipoVehiculos);
        }

        public void EliminarTipoVehiculos(int Id)
        {
            var item = _repository.GetById(Id);
            _repository.Delete(item);
        }

        public IEnumerable<TipoVehiculos> GetAllTipoTipoVehiculos()
        {
            return _repository.GetAll();
        }

        public TipoVehiculos GetTipoTipoVehiculos(int id)
        {
            return _repository.GetById(id);
        }
    }
}
