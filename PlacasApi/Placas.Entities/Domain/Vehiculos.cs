using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.Entities.Domain
{
    public class Vehiculos:BaseEntity
    {
        [Key]
        public int IdVehiculos { get; set; }
        public string Modelo { get; set; } = "";
        public string Chasi { get; set; } = "";  
        public string Color { get; set; } = "";
        public string Ano { get; set; } = "";

        public int Id { get; set; }
        public TipoVehiculos? TipoVehiculos { get; set; }
    }
}
