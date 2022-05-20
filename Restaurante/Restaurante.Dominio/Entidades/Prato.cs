using System;
using System.ComponentModel.DataAnnotations;

namespace Restaurante.Dominio.Entidades
{
    public class Prato:EntidadeBase
    {
        [Required(ErrorMessage = "O campo nome é obrigadoria")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="O campo Preço é obrigatório")]
        public double Preco { get; set; }
    }
}
