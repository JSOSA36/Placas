using Placas.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.Entities.Interfaces
{
    public interface IVehiculos
    {
        void AgregarVehiculo(Vehiculos vehiculos);
        void ActualizarVehiculos(int Id,Vehiculos vehiculos);
        Vehiculos GetVehiculoById(int id);
        IEnumerable<Vehiculos> GetAllVehiculos();
        void EliminarVehiculo(int id);  

    }
}
