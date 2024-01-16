using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CadastroProdutos.Solution.Models;
using CadastroProdutos.Solution.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CadastroProdutos.Solution.Controllers
{
    [Route("[controller]")]
    public class ProdutoController : Controller
    {
        private readonly IServiceProduto _serviceProduto;
        public ProdutoController(IServiceProduto serviceProduto)
        {
            _serviceProduto = serviceProduto;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }



        [HttpGet]
        [Route("ListProduto")]
        public async Task<IActionResult> ListProduto()
        {
            try
            {
                var produtos = await _serviceProduto.GetAllAsync();
                return Json(produtos);
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes
                Console.WriteLine(ex.Message);

                // Return an appropriate error response
                return StatusCode(500, new { error = "Internal Server Error" });
            }
        }
      

    }
}