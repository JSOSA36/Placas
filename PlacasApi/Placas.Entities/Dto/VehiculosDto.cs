using Placas.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.Entities.Dto
{
    public class VehiculosDto:BaseEntity
    {
        public int IdVehiculos { get; set; }
        public string Modelo { get; set; } = "";
        public string Chasi { get; set; } = "";
        public string Color { get; set; } = "";
        public string Ano { get; set; } = "";

        public int Id { get; set; }
    }
}
