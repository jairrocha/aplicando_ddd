using AutoMapper;
using Restaurante.Aplicacao.DTO;
using Restaurante.Dominio.Entidades;

namespace Restaurante.Aplicacao.Profiles
{
    public class PratoProfile: Profile
    {
        public PratoProfile()
        {
            CreateMap<Prato, PratoDTO>();
            CreateMap<PratoDTO, Prato>();
        }
    }
}
