using Placas.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.Entities.Interfaces
{
    public interface ITipoPersona
    {
        void AgregarTipoPersona(TipoPersona tipoPersona);
        void ActualizarTipoPersona(TipoPersona tipoPersona);
        TipoPersona GetTipoPersonaById(int id);
        IEnumerable<TipoPersona> GetAllTipoPersona();
        void EliminarTipoPersona(int id);

    }
}
