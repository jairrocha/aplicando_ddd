using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Restaurante.Dominio.Entidades
{
    public class Prato:EntidadeBase
    {
        [Required(ErrorMessage = "O campo nome é obrigadoria")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="O campo Preço é obrigatório")]
        public double Preco { get; set; }
        [JsonIgnore]
        public virtual IEnumerable<PratoDia> PratosDia { get; set; }


    }
}
