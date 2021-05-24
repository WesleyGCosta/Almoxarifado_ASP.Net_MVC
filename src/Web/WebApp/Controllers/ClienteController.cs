using Dominio.IRepositories;
using Historia.Clientes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Factories;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ClienteController : Controller
    {

        private readonly CriarCliente _criarCliente;
        private readonly AlterarCliente _alterarCliente;
        private readonly ConsultarCliente _consultarCliente;
        private readonly ExcluirCliente _excluirCliente;

        public ClienteController(IClienteRepository clienteRepository)
        {
            _criarCliente = new CriarCliente(clienteRepository);
            _alterarCliente = new AlterarCliente(clienteRepository);
            _consultarCliente = new ConsultarCliente(clienteRepository);
            _excluirCliente = new ExcluirCliente(clienteRepository);

        }

        public async Task<IActionResult> Index()
        {
            var ListaClientes = await _consultarCliente.ListarTodosClientes();
            var ListarClientesViewModel = ClienteFactory.MapearClienteViewodel(ListaClientes);

            return View(ListarClientesViewModel);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Criar(ClienteViewModel clienteViewModel)
        {
            if (ModelState.IsValid)
            {
                var cliente = ClienteFactory.MapearCliente(clienteViewModel);

                await _criarCliente.Executar(cliente);

                return RedirectToAction("Index");
            }

            return View(clienteViewModel);
        }


        //aqui
        public async Task<IActionResult> Alterar(int id)
        {
            var cliente = await _consultarCliente.BuscarPorId(id);

            if (cliente == null)
            {
                return RedirectToAction("Index");
            }

            var autorViewModel = ClienteFactory.MapearClienteViewodel(cliente);

            return View(autorViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Alterar(int id, ClienteViewModel clienteViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(clienteViewModel);
            }

            var autor = ClienteFactory.MapearCliente(clienteViewModel);

            await _alterarCliente.Executar(id, autor);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detalhar(int id)
        {
            var cliente= await _consultarCliente.BuscarPorId(id);

            if (cliente == null)
            {
                return RedirectToAction("Index");
            }

            var autorViewModel = ClienteFactory.MapearClienteViewodel(cliente);

            return View(autorViewModel);
        }

        public async Task<IActionResult> Excluir(int id)
        {
            var cliente = await _consultarCliente.BuscarPorId(id);

            if (cliente == null)
            {
                return RedirectToAction("Index");
            }


            await _excluirCliente.Executar(cliente);

            return RedirectToAction("Index");
        }

        public IActionResult Teste()
        {
            return View();
        }


    }
}
