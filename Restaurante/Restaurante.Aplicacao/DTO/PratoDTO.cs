using Restaurante.Dominio.Entidades;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Restaurante.Aplicacao.DTO
{
    public class PratoDTO:DTOBase
    {
        [Required(ErrorMessage = "O campo nome é obrigadoria")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo Preço é obrigatório")]
        public double Preco { get; set; }
        [JsonIgnore]
        public object PratosDia { get; set; }
    }
}
