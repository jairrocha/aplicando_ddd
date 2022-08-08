using AutoMapper;
using Restaurante.Aplicacao.DTO.PratoDia;
using Restaurante.Dominio.Entidades;

namespace Restaurante.Aplicacao.Profiles
{
    public class PratoDiaProfile : Profile
    {
        public PratoDiaProfile()
        {
            CreateMap<PratoDia, ReadPratoDiaDTO>();
            CreateMap<PratoDia, AlterPratoDiaDTO>();
            CreateMap<PratoDia, CreatePratoDiaDTO>();
            
            CreateMap<CreatePratoDiaDTO, PratoDia>();
        }
    }
}
