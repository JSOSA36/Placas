using Placas.Entities.Domain;
using Placas.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.DataAccess.Servicios
{
    public class TipoPersonaServices : ITipoPersona
    {

        public IRepository<TipoPersona> _repository { get; set; }
        public TipoPersonaServices(IRepository<TipoPersona> repository)
        {
            _repository = repository;
        }
        public void ActualizarTipoPersona(TipoPersona tipoPersona)
        {
            _repository.Update(tipoPersona.IdTipoPersona, tipoPersona);
        }

        public void AgregarTipoPersona(TipoPersona tipoPersona)
        {
            _repository.Add(tipoPersona);
        }

        public void EliminarTipoPersona(int Id)
        {
            var item = _repository.GetById(Id);
            _repository.Delete(item);
        }

        public IEnumerable<TipoPersona> GetAllTipoPersona()
        {
            return _repository.GetAll();    
        }

        public TipoPersona GetTipoPersonaById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
