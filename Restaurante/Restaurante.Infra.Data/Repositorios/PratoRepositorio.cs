using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Repositorios;
using Restaurante.Infra.Data.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Infra.Data.Repositorios
{
    public class PratoRepositorio: RepositorioBase<Prato>, IPratoRepositorio
    {
        public PratoRepositorio(Contexto contexto) : base(contexto)
        {
            
        }

    }
}
