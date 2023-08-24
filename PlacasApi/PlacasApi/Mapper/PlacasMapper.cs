using AutoMapper;
using Placas.Entities.Domain;
using Placas.Entities.Dto;

namespace PlacasApi.Mapper
{
    public class PlacasMapper: Profile
    {
        public PlacasMapper()
        {
            CreateMap<Usuarios, UsuariosDto>();
            CreateMap<UsuariosDto, Usuarios>();
            CreateMap<Clientes, ClientesDto>();
            CreateMap<ClientesDto, Clientes>();
            CreateMap<TipoVehiculos, TipoVehiculosDto>();
            CreateMap<TipoVehiculosDto, TipoVehiculos>();
            CreateMap<TipoPersona,TipoPersonaDto>();
            CreateMap<TipoPersonaDto,TipoPersona>();
            CreateMap<Vehiculos, VehiculosDto>();
            CreateMap<VehiculosDto, Vehiculos>();
          
            CreateMap<PlacasDto, Placas.Entities.Domain.Placas>();
            CreateMap<Placas.Entities.Domain.Placas, PlacasDto>();


        }
    }
}
