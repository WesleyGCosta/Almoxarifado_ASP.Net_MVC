using Dominio.IRepositories;
using Historia.Produtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Factories;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly CriarProduto _criarProduto;
        private readonly ConsultarProduto _consultarProduto;
        private readonly AlterarProduto _alterarProduto;
        private readonly ExcluirProduto _excluirProduto;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _criarProduto = new CriarProduto(produtoRepository);
            _consultarProduto = new ConsultarProduto(produtoRepository);
            _alterarProduto = new AlterarProduto(produtoRepository);
            _excluirProduto = new ExcluirProduto(produtoRepository);
        }
    
        public async Task<IActionResult> Index()
        {
            var listaProduto = await _consultarProduto.ListarTodosProdutos();
            var listaProdutoViewModel = ProdutoFactory.MapearListaProdutoViewModel(listaProduto);
            
            
            return View(listaProdutoViewModel);
        }
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar(ProdutoViewModel produtoViewModel)
        {
            if(ModelState.IsValid)
            {
                var produto = ProdutoFactory.MapearProduto(produtoViewModel);

                await _criarProduto.Executar(produto);
                
                return RedirectToAction("Index");
            }

            return View(produtoViewModel);
        }    
        
        public async Task<IActionResult> Alterar(int id)
        {
            var produto = await _consultarProduto.BuscarPorId(id);

            if(produto == null)
            {
                return RedirectToAction("Index");
            }

            var produtoViewModel = ProdutoFactory.MapearProdutoViewModel(produto);

            return View(produtoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Alterar(int id, ProdutoViewModel produtoViewModel)
        {
            if(!ModelState.IsValid)
            {
                return View(produtoViewModel);
            }

            var produto = ProdutoFactory.MapearProduto(produtoViewModel);

            await _alterarProduto.Executar(id, produto);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detalhar(int id)
        {
            var produto = await _consultarProduto.BuscarPorId(id);

            if(produto == null)
            {
                return RedirectToAction("Index");
            }

            var produtoViewModel = ProdutoFactory.MapearProdutoViewModel(produto);

            return View(produtoViewModel);
        }

        public async Task<IActionResult> Excluir(int id)
        {
            var produto = await _consultarProduto.BuscarPorId(id);

            if(produto == null)
            {
                return RedirectToAction("Index");
            }

            await _excluirProduto.Executar(produto);

            return RedirectToAction("Index");
        }
    }
}
