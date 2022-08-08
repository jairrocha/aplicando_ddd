using AutoMapper;
using Restaurante.Aplicacao.DTO.CardapioDTO;
using Restaurante.Dominio.Entidades;
using System.Linq;

namespace Restaurante.Aplicacao.Profiles
{
    public class CardapioProfile : Profile
    {
        public CardapioProfile()
        {

            CreateMap<Cardapio, AlterCardapioDTO>();
            CreateMap<Cardapio, CreateCardapioDTO>();
            CreateMap<Cardapio, ReadCardapioDTO>()
                .ForMember(p => p.PratosDia, opt => opt
                .MapFrom(p => p.PratosDia
                .Select(_ => new { _.Prato.Id, _.Prato.Nome, _.Prato.Preco })));


            CreateMap<AlterCardapioDTO, Cardapio>();
            //CreateMap<ReadCardapioDTO, Cardapio >();
            //CreateMap<CreateCardapioDTO, Cardapio >();
        }
    }
}
