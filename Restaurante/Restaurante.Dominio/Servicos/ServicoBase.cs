using Restaurante.Dominio.Entidades;
using Restaurante.Dominio.Interfaces.Repositorios;
using Restaurante.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Dominio.Servicos
{
    public class ServicoBase<TEntidade> : IServicoBase<TEntidade> where TEntidade : EntidadeBase
    {
        private readonly IRepositorioBase<TEntidade> _repositorio;

        public ServicoBase(IRepositorioBase<TEntidade> repositorio)
        {
            this._repositorio = repositorio;
        }
        public void Alterar(TEntidade entidade)
        {
            _repositorio.Alterar(entidade);
        }

        public void Excluir(int id)
        {
            _repositorio.Excluir(id);
        }

        public void Excluir(TEntidade entidade)
        {
            _repositorio.Excluir(entidade);
        }

        public int Incluir(TEntidade entidade)
        {
            return _repositorio.Incluir(entidade);
        }

        public TEntidade SelecionarPorId(int Id)
        {
            return _repositorio.SelecionarPorId(Id);
        }

        public IEnumerable<TEntidade> SelecionarTodos()
        {
            return _repositorio.SelecionarTodos();
        }
    }
}
