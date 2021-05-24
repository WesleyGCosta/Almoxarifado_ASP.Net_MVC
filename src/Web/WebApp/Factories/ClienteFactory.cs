using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Factories
{
    public class ClienteFactory
    {
        public static ClienteViewModel MapearClienteViewodel(Cliente cliente)
        {
            var clienteViewModel = new ClienteViewModel
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Cpf = cliente.Cpf,
                DataDeNascimento = cliente.DataDeNascimento,
                Telefone = cliente.Telefone,
                Endereco = cliente.Endereco,
                Bairro = cliente.Bairro,
                
            };

            return clienteViewModel;
        }
        public static Cliente MapearCliente(ClienteViewModel clienteViewModel)
        {
            var cliente = new Cliente(clienteViewModel.Nome,
                clienteViewModel.Telefone, clienteViewModel.Endereco,
                clienteViewModel.Cpf, clienteViewModel.DataDeNascimento,
                clienteViewModel.Bairro, sexo: clienteViewModel.Sexo);

            return cliente;
        }

        internal static object MapearClienteViewodel(IEnumerable<Cliente> listaClientes)
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<ClienteViewModel> MapearListaClienteViewModel(IEnumerable<Cliente> clientes)
        {
            var lista = new List<ClienteViewModel>();
            foreach (var item in clientes)
            {
                lista.Add(MapearListaClienteViewModel(item));
            }

            return lista;
        }

        
    }
}
