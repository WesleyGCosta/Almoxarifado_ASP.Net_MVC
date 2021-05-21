using Dominio.Entidades;
using Dominio.IRepositories;
using System.Threading.Tasks;

namespace Historia.Clientes
{
    public class AlterarCliente
    {
        private readonly IClienteRepository _clienteRepository;

        public AlterarCliente(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task Executar(int id, Cliente cliente)
        {
            var dadosDoCliente = await _clienteRepository.BuscarPorId(id);

            dadosDoCliente.AtualizarCliente(cliente.Nome, cliente.Cpf,
                cliente.DataDeNascimento, cliente.Telefone, cliente.Endereco,
                cliente.Bairro, cliente.Sexo);

            await _clienteRepository.Alterar(dadosDoCliente);
        }


    }
}
