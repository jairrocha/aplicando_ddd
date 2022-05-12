using AutoMapper;
using Restaurante.Aplicacao.DTO;
using Restaurante.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Aplicacao
{
    public class MappingEntidade:Profile
    {
        public MappingEntidade()
        {
            CreateMap<Prato, PratoDTO>();
            CreateMap<PratoDTO, Prato>();
        }
    }
}
