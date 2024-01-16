using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroProdutos.Solution.Data;
using CadastroProdutos.Solution.Models;

namespace CadastroProdutos.Solution.Repository
{
    public class RepositoryCategoria : IRepositoryCategoria
    {
        private readonly Contexto _contexto;
        public RepositoryCategoria(Contexto contexto)
        {
            _contexto = contexto;
        }
        public IEnumerable<Categoria> GetAll()
        {
            return _contexto.Categorias.ToList();
        }
        public Categoria Create(Categoria categoria)
        {
            _contexto.Categorias.Add(categoria);
            _contexto.SaveChanges();
            return categoria;
        }
        public Categoria GetById(int id)
        {
            return _contexto.Categorias.Find(id);
        }
        public Categoria Update(Categoria categoria)
        {
            _contexto.Categorias.Update(categoria);
            _contexto.SaveChanges();
            return categoria;
        }
        public void Delete(int id)
        {
            var categoria = _contexto.Categorias.Find(id);
            _contexto.Remove(categoria);
            _contexto.SaveChanges();
        }

    }
}