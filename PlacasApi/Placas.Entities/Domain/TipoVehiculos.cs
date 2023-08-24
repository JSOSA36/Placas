using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.Entities.Domain
{
    public class TipoVehiculos:BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string? Tipo { get; set; } = "";
       
    }
}
