using Microsoft.EntityFrameworkCore;
using Placas.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.DataAccess.Data
{
    public class PlacasContext : DbContext
    {
        public PlacasContext()
        {

        }
        public PlacasContext(DbContextOptions<PlacasContext> options)
           : base(options)


        {

        }

        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<TipoPlacas> TipoPlacas { get; set; }
        public virtual DbSet<Vehiculos> Vehiculos { get; set; }
        public virtual DbSet<TipoVehiculos> TipoVehiculos { get; set; }
        public virtual DbSet<TipoPersona> TipoPersonas { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }

        public virtual DbSet<Entities.Domain.Placas> Placas { get; set; }


    }
}
