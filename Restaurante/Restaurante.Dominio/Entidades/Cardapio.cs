using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Restaurante.Dominio.Entidades
{
    public class Cardapio : EntidadeBase
    {
        [Required(ErrorMessage = "O dia é obrigatório")]
        public int CodDia { get; set; }
        public string Dia { get; set; }
        [JsonIgnore]
        public virtual IEnumerable<PratoDia> PratosDia { get; set; }

    }
}
