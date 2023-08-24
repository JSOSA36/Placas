using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.Entities.Domain
{
    public class TipoPersona:BaseEntity
    {
        [Key]
        public int IdTipoPersona { get; set; }
        public string Tipo { get; set; } = "";
    }
}
