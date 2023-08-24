using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.Entities.Domain
{
    public class Usuarios:BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
        public string UserName { get; set; } = "";
        public string PassWord { get;set; } = "";


       
    }
}
