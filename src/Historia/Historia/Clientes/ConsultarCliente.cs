using Dominio.Entidades;
using Dominio.IRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Historia.Clientes
{
    public class ConsultarCliente
    {
        private readonly IClienteRepository _clienteRepository;

        public ConsultarCliente(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<Cliente> BuscarPorId(int id)
        {
            return await _clienteRepository.BuscarPorId(id);
        }

        public async Task<IEnumerable<Cliente>> ListarTodosClientes()
        {
            return await _clienteRepository.ListarTodosClientes();
        }
    }
}
