using System.ComponentModel.DataAnnotations;

namespace Restaurante.Aplicacao.DTO.CardapioDTO
{
    public class AlterCardapioDTO : DTOBase
    {
       
        public int CodDia { get; set; }
        public string Dia { get; set; }
    }
}
