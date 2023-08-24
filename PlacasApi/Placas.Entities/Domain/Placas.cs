using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.Entities.Domain
{
    public class Placas:BaseEntity
    {
        [Key]
        public int IdVentasPlacaHeader { get; set; }
        public int IdClientes { get; set; }
        public decimal MontoTotal { get; set; }
        public int IdTipoPlacas { get; set; }
        public int IdVehiculos { get; set; }

        public string NumeroPlaca { get; set; } = "";
        public virtual TipoPlacas? TipoPlacas { get; set; }
        public virtual Vehiculos? Vehiculos { get; set; }
        public virtual Clientes? Clientes { get; set; }
    }
}
