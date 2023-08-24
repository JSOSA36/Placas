using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.Entities.Domain
{
    public class Clientes:BaseEntity
    {
        [Key]
        public int IdClientes { get; set; }
        public string Cedula { get; set; } = "";
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public DateTime FechaNacimiento { get; set; }
        public int IdTipoPersona { get; set; }
        public virtual TipoPersona? TipoPersona { get; set; }

    }
}
