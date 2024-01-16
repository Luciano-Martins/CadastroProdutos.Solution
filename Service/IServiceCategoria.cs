using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroProdutos.Solution.Models;

namespace CadastroProdutos.Solution.Service
{
    public interface IServiceCategoria
    {
        IEnumerable<Categoria> GetAll();
        Categoria GetById(int id);
        Categoria Update(Categoria categoria);
        Categoria Create(Categoria categoria);
        public void Delete(int id);

    }
}