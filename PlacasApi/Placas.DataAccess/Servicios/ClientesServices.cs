using Placas.Entities.Domain;
using Placas.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.DataAccess.Servicios
{
    public class ClientesServices : IClientes
    {
        public IRepository<Clientes> _repository { get; set; }
        public ClientesServices(IRepository<Clientes> repository)
        {
            _repository = repository;
        }
        public void ActualizarCliente(Clientes clientes)
        {
             _repository.Update(clientes.IdClientes,clientes);
        }

        public void AgregarCliente(Clientes clientes)
        {
            _repository.Add(clientes);
        }

        public void EliminarCliente(int Id)
        {
            var item = _repository.GetById(Id);
            _repository.Delete(item);
        }

        public IEnumerable<Clientes> GetAllClientes()
        {
            return _repository.GetAll("TipoPersona");
        }

        public Clientes GetClienteById(int id)
        {
            return  _repository.GetById(id);
        }
    }
}
