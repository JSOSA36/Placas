using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.Entities.Domain
{
    public class TipoPlacas:BaseEntity
    {
        [Key]
        public int IdTipoPlacas { get; set; }
        public string Tipo { get; set; } = "";
        public decimal Precio { get; set; }
    }
}
