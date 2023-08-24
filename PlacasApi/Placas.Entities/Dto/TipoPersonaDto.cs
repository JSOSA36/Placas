using Placas.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.Entities.Dto
{
    public class TipoPersonaDto:BaseEntity
    {
        public int IdTipoPersona { get; set; }
        public string Tipo { get; set; } = "";
    }
}
