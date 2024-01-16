using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroProdutos.Solution.Models;
using CadastroProdutos.Solution.Repository;

namespace CadastroProdutos.Solution.Service
{
    public class ServiceCategoria : IServiceCategoria
    {
        private readonly IRepositoryCategoria _repositoryCategoria;
        public ServiceCategoria(IRepositoryCategoria repositoryCategoria)
        {
            _repositoryCategoria = repositoryCategoria;
        }
        public IEnumerable<Categoria> GetAll()
        {
            var categoriaList = _repositoryCategoria.GetAll();
            return categoriaList;
        }
        public Categoria Create(Categoria categoria)
        {
            categoria = _repositoryCategoria.Create(categoria);
            return categoria;
        }
        public Categoria GetById(int id)
        {
            return _repositoryCategoria.GetById(id);
        }

        public Categoria Update(Categoria categoria)
        {
            return _repositoryCategoria.Update(categoria);
        }
        public void Delete(int id)
        {
            _repositoryCategoria.Delete(id);
        }
    }
}