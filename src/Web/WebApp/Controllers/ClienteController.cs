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

        
    }
}
