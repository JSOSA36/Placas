using Placas.Entities.Domain;
using Placas.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Placas.DataAccess.Servicios
{
    public class PlacasServices : IPlacas
    {

        public IRepository<Entities.Domain.Placas> _repository { get; set; }
        
        public PlacasServices(IRepository<Entities.Domain.Placas> repository)
        {
            _repository = repository;
        }
        public void ActualizarPlacas(Entities.Domain.Placas Placas)
        {
            _repository.Update(Placas.IdTipoPlacas, Placas);
        }

        public void AgregarPlacas(Entities.Domain.Placas Placas)
        {
            _repository.Add(Placas);
        }

        public void EliminarPlacas(int Id)
        {
            var item = _repository.GetById(Id);
            _repository.Delete(item);
        }

        public string GenerarNumeroPlaca(Vehiculos vehiculos)
        {
            string _NumeroPlaca = string.Empty;

           

            int longitud = 6;
            const string alfabeto = "0123456789";
            StringBuilder token = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < longitud; i++)
            {
                int indice = rnd.Next(alfabeto.Length);
                token.Append(alfabeto[indice]);
            }

            switch (vehiculos.TipoVehiculos.Tipo)
            {
                case "Publico":
                   _NumeroPlaca="A"+token.ToString();
                    break;
                case "Privado":
                    _NumeroPlaca = "F" + token.ToString();
                    break;
                case "Transporte":
                    _NumeroPlaca = "T" + token.ToString();
                    break;
                case "Pesado":
                    _NumeroPlaca = "P" + token.ToString();
                    break;
                
            }

            return _NumeroPlaca;
        }

        public IEnumerable<Entities.Domain.Placas> GetAllPlacas()
        {
            return _repository.GetAll("TipoPlacas","Vehiculos","Clientes");
        }

        public IEnumerable<Entities.Domain.Placas> GetPlacasByCliente(int IdCliente)
        {
            return _repository.GetByExpressionList("Clientes", 
                "Vehiculos", c => c.IdClientes == IdCliente);
        }

        public Entities.Domain.Placas GetPlacasById(int Id)
        {
            return _repository.GetById(Id);
        }

        public bool VehiculoTienesPlaca(int IdVehiculo)
        {
            return _repository.Any(c=>c.IdVehiculos==IdVehiculo);
        }
    }
}
