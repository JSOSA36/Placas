using Placas.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.Entities.Interfaces
{
    public interface ITipoVehiculos
    {
        void AgregarTipoTipoVehiculos(TipoVehiculos TipoVehiculos);
        void ActualizarTipoVehiculos(TipoVehiculos TipoVehiculos);
        TipoVehiculos GetTipoTipoVehiculos(int id);
        IEnumerable<TipoVehiculos> GetAllTipoTipoVehiculos();
        void EliminarTipoVehiculos(int id);    
    }
}
