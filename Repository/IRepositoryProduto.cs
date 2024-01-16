using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroProdutos.Solution.Models;

namespace CadastroProdutos.Solution.Repository
{
    public interface IRepositoryProduto
    {
        Task<IEnumerable<Produto>> GetAllAsync();
        Task<Produto> GetByIdAsync(int id);
        Task<Produto> UpdateAsync(Produto produto);
        Task<Produto> CreateAsync(Produto produto);
        Task DeleteAsync(int id);
    }
}