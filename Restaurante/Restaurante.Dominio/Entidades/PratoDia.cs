using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Dominio.Entidades
{
    public class PratoDia : EntidadeBase
    {
        [Required(ErrorMessage ="O cárdapio é obrigatório")]
        public int CardapioId { get; set; }

        [Required(ErrorMessage ="O prato é obrigatório")]
        public int PratoId { get; set; }
        public virtual Cardapio Cardapio { get; set; }
        public virtual Prato Prato { get; set; }

    }
}
