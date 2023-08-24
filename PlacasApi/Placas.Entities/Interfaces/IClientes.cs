using Placas.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.Entities.Interfaces
{
    public interface IClientes
    {
        void AgregarCliente(Domain.Clientes clientes);
        void ActualizarCliente(Domain.Clientes clientes);
        IEnumerable<Clientes> GetAllClientes();
        Clientes GetClienteById(int id);
        void EliminarCliente(int id);
    } 
}
