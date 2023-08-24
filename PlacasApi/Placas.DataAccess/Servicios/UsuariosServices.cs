using Placas.Entities.Domain;
using Placas.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.DataAccess.Servicios
{
    public class UsuariosServices : IUsuarios
    {
        public IRepository<Usuarios> _repository { get; set; }

        public UsuariosServices(IRepository<Usuarios> repository)
        {
            _repository = repository;
        }

        public void ActualizarUsuario(int Id,Usuarios usuarios)
        {
            usuarios.Id = Id;
            _repository.Update(Id,usuarios);
        }

        public void AgregarUsuario(Usuarios usuarios)
        {
                _repository.Add(usuarios);
        }

        public void EliminarUsuario(int Id)
        {
            var item = _repository.GetById(Id);
            _repository.Delete(item);
        }

        public IEnumerable<Usuarios> GetAllUsuarios()
        {
            return _repository.GetAll();
        }

        public Usuarios GetUsuarioById(int id)
        {
            return _repository.GetById(id);
        }

        public Usuarios GetUsuarioByUserPassword(string Usuario, string Password)
        {
            return _repository.GetByExpression(c=>c.UserName==Usuario && c.PassWord==Password);
        }
    }
}
