using System.ComponentModel.DataAnnotations;

namespace Restaurante.Aplicacao.DTO
{
    public class PratoDTO:DTOBase
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Preço é obrigatório")]
        public double Preco { get; set; }
    }
}
