using Dominio.Entidades;
using Dominio.IRepositories;
using System.Threading.Tasks;

namespace Historia.Clientes
{
    public class ExcluirCliente
    {
        private readonly IClienteRepository _clienteRepository;

        public ExcluirCliente(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task Executar(Cliente cliente)
        {
            await _clienteRepository.Excluir(cliente);
        }
    }
}
