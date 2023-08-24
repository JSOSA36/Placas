using Placas.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.Entities.Interfaces
{
    public interface ITipoPlaca
    {
        void AgregarTipoPlaca(TipoPlacas tipoPlacas);
        void ActualizarTipoPlaca(TipoPlacas tipoPlacas);
        IEnumerable<TipoPlacas> GetAllTipoPlacas();
        TipoPlacas GetTipoPlacaById(int id);
        void EliminarTipoPlaca(int id);
    }
}
