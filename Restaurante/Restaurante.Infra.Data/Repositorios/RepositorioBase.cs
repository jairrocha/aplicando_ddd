using Microsoft.EntityFrameworkCore;
using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Repositorios;
using Restaurante.Infra.Data.Contextos;
using Restaurante.Infra.Data.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Infra.Data.Repositorios
{
    public class RepositorioBase<TEntidade> : IRepositorioBase<TEntidade>
        where TEntidade : EntidadeBase
    {
        private readonly Contexto contexto;

        public RepositorioBase(Contexto contexto) : base()
        {
            this.contexto = contexto;
        }

        public void Alterar(TEntidade entidade)
        {

            if (contexto.Set<TEntidade>().Attach(entidade).GetDatabaseValues() == null)
            {
                throw new EntityNotFoundException();
            }

            contexto.InitTransacao();
            contexto.Entry(entidade).State = EntityState.Modified;
            contexto.SendChanges();

        }

        public void Excluir(int Id)
        {
            var entidade = SelecionarPorId(Id);
            if (entidade == null)
            {
                throw new EntityNotFoundException();
            }
            
            contexto.InitTransacao();
            contexto.Set<TEntidade>().Remove(entidade);
            contexto.SendChanges();

        }

        public void Excluir(TEntidade entidade)
        {
          
            if (SelecionarPorId(entidade.Id) == null)
            {
                throw new EntityNotFoundException();
            }

            contexto.InitTransacao();
            contexto.Set<TEntidade>().Remove(entidade);
            contexto.SendChanges();

        }

        public int Incluir(TEntidade entidade)
        {
            contexto.InitTransacao();
            contexto.Set<TEntidade>().Add(entidade);
            contexto.SendChanges();
            return entidade.Id;
        }

        public TEntidade SelecionarPorId(int Id)
        {
            return contexto.Set<TEntidade>().Find(Id);
        }

        public IEnumerable<TEntidade> SelecionarTodos()
        {
            return contexto.Set<TEntidade>().ToList();
        }
    }
}
