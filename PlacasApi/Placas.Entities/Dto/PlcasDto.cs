using Placas.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.Entities.Dto
{
    public class PlacasDto : BaseEntity
    {
        public int IdVentasPlacaHeader { get; set; }
        public int IdClientes { get; set; }
        public decimal MontoTotal { get; set; }
        public int IdTipoPlacas { get; set; }
        public int IdVehiculos { get; set; }
        public string NumeroPlaca { get; set; } = "";
    }
}
