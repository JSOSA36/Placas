using Placas.Entities.Domain;
using Placas.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.DataAccess.Data
{
    public class LoadData
    {

        PlacasContext PlacasContext = new PlacasContext();
       
        public void CargarDatosPersona()
        {
            var Result = PlacasContext.TipoPersonas.ToList();
            if(Result==null)
            {
                TipoPersona tipoPersona = new TipoPersona();
                tipoPersona.Tipo = "Fisica";
                PlacasContext.TipoPersonas.Add(tipoPersona);
                tipoPersona = new TipoPersona();
                tipoPersona.Tipo = "Juridica";
                PlacasContext.TipoPersonas.Add(tipoPersona);


            }
        }
        public void CargarTipoVehiculos()
        {
            var result = PlacasContext.TipoVehiculos.ToList();
            if(result==null)
            {
                TipoVehiculos tipoVehiculos = new TipoVehiculos();
                tipoVehiculos.Tipo = "Publico";
                PlacasContext.Add(tipoVehiculos);
                tipoVehiculos = new TipoVehiculos();
                tipoVehiculos.Tipo = "Privado";
                PlacasContext.Add(tipoVehiculos);
                tipoVehiculos = new TipoVehiculos();
                tipoVehiculos.Tipo = "Transporte ";
                PlacasContext.Add(tipoVehiculos);
                tipoVehiculos = new TipoVehiculos();
                tipoVehiculos.Tipo = "Pesado ";
                PlacasContext.Add(tipoVehiculos);
            }
            

        }
        public void CartTipoPlacas()
        {
            var result= PlacasContext.TipoPlacas.ToList();


            if (result==null)
            {
                TipoPlacas tipoPlacas = new TipoPlacas();
                tipoPlacas.Tipo = " Placas de dealers";
                tipoPlacas.Precio = 2000;
                PlacasContext.Add(tipoPlacas);
                tipoPlacas = new TipoPlacas();
                tipoPlacas.Tipo = " Placas Provisionales";
                tipoPlacas.Precio = 1500;
                PlacasContext.Add(tipoPlacas);
                tipoPlacas = new TipoPlacas();
                tipoPlacas.Tipo = "Placas de motocicletas";
                tipoPlacas.Precio = 1000;
                PlacasContext.Add(tipoPlacas);

            }

        }
    }
}
