using System.ComponentModel.DataAnnotations;

namespace Restaurante.Aplicacao.DTO.PratoDia
{
    public class AlterPratoDiaDTO:DTOBase
    {
        [Required(ErrorMessage = "O cárdapio é obrigatório")]
        public int CardapioId { get; set; }

        [Required(ErrorMessage = "O prato é obrigatório")]
        public int PratoId { get; set; }

    }
}
