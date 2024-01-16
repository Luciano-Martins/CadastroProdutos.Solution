using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroProdutos.Solution.Data;
using CadastroProdutos.Solution.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroProdutos.Solution.Repository
{
    public class RepositoryProduto : IRepositoryProduto
    {
        private readonly Contexto _contexto;
        public RepositoryProduto(Contexto contexto)
        {
            _contexto = contexto;
        }
        public async Task<IEnumerable<Produto>> GetAllAsync()
        {
            return await _contexto.Produtos.ToListAsync();
        }
        public async Task<Produto> CreateAsync(Produto produto)
        {
            _contexto.Produtos.Add(produto);
            await _contexto.SaveChangesAsync();
            return produto;
        }
        public async Task<Produto> GetByIdAsync(int id)
        {
            return await _contexto.Produtos.FindAsync(id);
        }
        public async Task<Produto> UpdateAsync(Produto produto)
        {
            _contexto.Produtos.Update(produto);
            await _contexto.SaveChangesAsync();
            return produto;
        }
        public async Task DeleteAsync(int id)
        {
            var produto = await _contexto.Produtos.FindAsync(id);
            if (produto != null)
            {
                _contexto.Produtos.Remove(produto);
                await _contexto.SaveChangesAsync();
            }
        }
    }
}