using System;
using System.ComponentModel.DataAnnotations;

namespace Restaurante.Dominio.Entidades
{
    public class Prato:EntidadeBase
    {
        [Required]
        public string Nome { get; set; }

        public double Preco { get; set; }
    }
}
