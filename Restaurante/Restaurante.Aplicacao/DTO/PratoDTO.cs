using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Aplicacao.DTO
{
    public class PratoDTO:DTOBase
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
    }
}
