using System.ComponentModel.DataAnnotations;

namespace Restaurante.Aplicacao.DTO.CardapioDTO
{
    public class ReadCardapioDTO : DTOBase
    {
        [Required(ErrorMessage = "O dia é obrigatório")]
        public int CodDia { get; set; }
        public string Dia { get; set; }
        public object PratosDia { get; set; }


    }
}
