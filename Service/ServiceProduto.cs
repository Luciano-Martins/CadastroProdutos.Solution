using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroProdutos.Solution.Data;
using CadastroProdutos.Solution.Models;
using CadastroProdutos.Solution.Repository;
using Microsoft.EntityFrameworkCore;

namespace CadastroProdutos.Solution.Service
{
    public class ServiceProduto : IServiceProduto
    {
        private readonly IRepositoryProduto _repositoryProduto;
        public ServiceProduto(IRepositoryProduto repositoryProduto)
        {
            _repositoryProduto = repositoryProduto;
        }
        public async Task<IEnumerable<Produto>> GetAllAsync()
        {
            return await _repositoryProduto.GetAllAsync();
        }
       
        public async Task DeleteAsync(int id)
        {
           await _repositoryProduto.DeleteAsync(id);
        }
        
        public async Task<Produto> GetByIdAsync(int id)
        {
            return await  _repositoryProduto.GetByIdAsync(id);
        }

        public async Task<Produto> UpdateAsync(Produto produto)
        {
            return await _repositoryProduto.UpdateAsync(produto);
        }

        public async Task<Produto> CreateAsync(Produto produto)
        {
            produto = await _repositoryProduto.CreateAsync(produto);
            return produto;
        }
    }
}