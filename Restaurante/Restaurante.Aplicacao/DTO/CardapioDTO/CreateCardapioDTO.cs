using System.ComponentModel.DataAnnotations;

namespace Restaurante.Aplicacao.DTO.CardapioDTO
{
    public class CreateCardapioDTO : DTOBase
    {
        [Required(ErrorMessage = "O dia é obrigatório")]
        public int CodDia { get; set; }
        public string Dia { get; set; }
      


    }
}
