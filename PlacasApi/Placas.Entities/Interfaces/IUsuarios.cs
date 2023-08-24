using Placas.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.Entities.Interfaces
{
    public interface IUsuarios
    {
        void AgregarUsuario(Usuarios usuarios);
        void ActualizarUsuario(int Id, Usuarios usuarios);
        Usuarios GetUsuarioById(int id);
        Usuarios GetUsuarioByUserPassword(string Usuario,string Password);
        IEnumerable<Usuarios> GetAllUsuarios();
        void EliminarUsuario(int id);

    }
}
