using Dominio.Entidades;
using Dominio.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historia.Clientes
{
    public class CriarCliente
    {
        private readonly IClienteRepository _clienteRepository;

        public CriarCliente(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task Executar(Cliente cliente)
        {
            await _clienteRepository.Criar(cliente);
        }
    }
}
