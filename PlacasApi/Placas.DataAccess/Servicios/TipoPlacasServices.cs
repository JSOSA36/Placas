using Placas.Entities.Domain;
using Placas.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.DataAccess.Servicios
{
    public class TipoPlacasServices : ITipoPlaca
    {
        public IRepository<TipoPlacas> _repository { get; set; }
        public TipoPlacasServices(IRepository<TipoPlacas> repository)
        {
            this._repository=repository;
        }
        public void ActualizarTipoPlaca(TipoPlacas tipoPlacas)
        {
            _repository.Update(tipoPlacas.IdTipoPlacas, tipoPlacas);
        }

        public void AgregarTipoPlaca(TipoPlacas tipoPlacas)
        {
            _repository.Add(tipoPlacas);
        }

        public void EliminarTipoPlaca(int Id)
        {
            var item = _repository.GetById(Id);
            _repository.Delete(item);
        }

        public IEnumerable<TipoPlacas> GetAllTipoPlacas()
        {
            return _repository.GetAll();
        }

        public TipoPlacas GetTipoPlacaById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
