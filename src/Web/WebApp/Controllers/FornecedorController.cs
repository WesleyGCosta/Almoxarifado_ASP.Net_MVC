using Dominio.IRepositories;
using Historia.Fornecedores;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApp.Factories;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class FornecedorController : Controller
    {
        private readonly CriarFornecedor _criarFornecedor;
        private readonly ConsultarFornecedor _consultarFornecedor;
        private readonly AlterarFornecedor _alterarFornecedor;
        private readonly ExcluirFornecedor _excluirFornecedor;
        
        public FornecedorController(IFornecedorRepository fornecedorRepository)
        {
            _criarFornecedor = new CriarFornecedor(fornecedorRepository);
            _consultarFornecedor = new ConsultarFornecedor(fornecedorRepository);
            _alterarFornecedor = new AlterarFornecedor(fornecedorRepository);
            _excluirFornecedor = new ExcluirFornecedor(fornecedorRepository);
        }
        
        public async Task<IActionResult> Index()
        {
            var listaFornecedores = await _consultarFornecedor.ListarTodosFornecedores();
            var listarFornecedorViewModel = FornecedorFactory.MapearListaFornecedorViewModel(listaFornecedores);

            return View(listarFornecedorViewModel);
        }
        

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar(FornecedorViewModel fornecedorViewModel)
        {
            if(ModelState.IsValid)
            {
                var fornecedor = FornecedorFactory.MapearFornecedor(fornecedorViewModel);

                await _criarFornecedor.Executar(fornecedor);

                return RedirectToAction("Index");
            }

            return View(fornecedorViewModel);
        }

        public async Task<IActionResult> Alterar(int id)
        {
            var fornecedor = await _consultarFornecedor.BuscarPorId(id);

            if(fornecedor == null)
            {
                return RedirectToAction("Index");
            }

            var fornecedorViewModel = FornecedorFactory.MapearFornecedorViewModel(fornecedor);

            return View(fornecedorViewModel);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Alterar(int id, FornecedorViewModel fornecedorViewModel)
        {
            if(!ModelState.IsValid)
            {
                return View(fornecedorViewModel);
            }

            var fornecedor = FornecedorFactory.MapearFornecedor(fornecedorViewModel);

            await _alterarFornecedor.Executar(id, fornecedor);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detalhar(int id)
        {
            var fornecedor = await _consultarFornecedor.BuscarPorId(id);

            if(fornecedor == null)
            {
                return RedirectToAction("Index");
            }

            var fornecedorViewModel = FornecedorFactory.MapearFornecedorViewModel(fornecedor);

            return View(fornecedorViewModel);
        }

        public async Task<IActionResult> Excluir(int id)
        {
            var fornecedor = await _consultarFornecedor.BuscarPorId(id);

            if(fornecedor == null)
            {
                return RedirectToAction("Index");
            }

            await _excluirFornecedor.Executar(fornecedor);

            return RedirectToAction("Index");
        }
    }
}
