using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.Entities.Domain
{
    public abstract class BaseEntity
    {
        public DateTime FechaRegistro { get; set; }
    }
}
