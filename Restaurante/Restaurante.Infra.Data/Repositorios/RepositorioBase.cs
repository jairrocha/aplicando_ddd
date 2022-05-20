using Microsoft.EntityFrameworkCore;
using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Repositorios;
using Restaurante.Infra.Data.Contextos;
using Restaurante.Infra.Data.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace Restaurante.Infra.Data.Repositorios
{
    public class RepositorioBase<TEntidade> : IRepositorioBase<TEntidade>
        where TEntidade : EntidadeBase
    {
        protected readonly Contexto _contexto;

        public RepositorioBase(Contexto contexto) : base()
        {
            _contexto = contexto;
        }

        public void Alterar(TEntidade entidade)
        {

            if (_contexto.Set<TEntidade>().Attach(entidade).GetDatabaseValues() == null)
            {
                throw new EntityNotFoundException();
            }

            _contexto.InitTransacao();
            _contexto.Entry(entidade).State = EntityState.Modified;
            _contexto.SendChanges();

        }

        public void Excluir(int Id)
        {
            var entidade = SelecionarPorId(Id);
            if (entidade == null)
            {
                throw new EntityNotFoundException();
            }
            
            _contexto.InitTransacao();
            _contexto.Set<TEntidade>().Remove(entidade);
            _contexto.SendChanges();

        }

        public void Excluir(TEntidade entidade)
        {
          
            if (SelecionarPorId(entidade.Id) == null)
            {
                throw new EntityNotFoundException();
            }

            _contexto.InitTransacao();
            _contexto.Set<TEntidade>().Remove(entidade);
            _contexto.SendChanges();

        }

        public int Incluir(TEntidade entidade)
        {
            _contexto.InitTransacao();
            _contexto.Set<TEntidade>().Add(entidade);
            _contexto.SendChanges();
            return entidade.Id;
        }

        public TEntidade SelecionarPorId(int Id)
        {
            return _contexto.Set<TEntidade>().Find(Id);
        }

        public IEnumerable<TEntidade> SelecionarTodos()
        {
            return _contexto.Set<TEntidade>().ToList();
        }
    }
}
