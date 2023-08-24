using Placas.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.Entities.Interfaces
{
    public interface IPlacas
    {
        void AgregarPlacas(Domain.Placas Plcas);
        void ActualizarPlacas(Domain.Placas Plcas);
        Domain.Placas GetPlacasById(int Id);
        IEnumerable<Domain.Placas> GetPlacasByCliente(int IdCliente);
        IEnumerable<Domain.Placas> GetAllPlacas();
        //string GenerarNumeroPlaca(Vehiculos vehiculos);
        bool VehiculoTienesPlaca(int IdVehiculo);
        void EliminarPlacas(int id);

    }
}
