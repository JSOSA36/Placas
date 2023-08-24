using Placas.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.Entities.Dto
{
    public class TipoPlacasDto:BaseEntity
    {
        public int IdTipoPlacas { get; set; }
        public string Tipo { get; set; } = "";
        public decimal Precio { get; set; }
    }
}
