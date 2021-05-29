using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Factories
{
    public static class FornecedorFactory
    {
        public static FornecedorViewModel MapearFornecedorViewModel(Fornecedor fornecedor)
        {
            var fornecedorViewModel = new FornecedorViewModel
            {
                Id = fornecedor.Id,
                Nome = fornecedor.Nome,
                RazaoSocial = fornecedor.RazaoSocial,
                Cnpj = fornecedor.Cnpj,
                Telefone = fornecedor.Telefone,
                Email = fornecedor.Email,
                Endereco = fornecedor.Endereco,
                Bairro = fornecedor.Bairro,
                Complemento = fornecedor.Complemento
            };

            return fornecedorViewModel;      
        }
        public static Fornecedor MapearFornecedor(FornecedorViewModel fornecedorViewModel)
        {
            var fornecedor = new Fornecedor(
                fornecedorViewModel.Nome,
                fornecedorViewModel.RazaoSocial,
                fornecedorViewModel.Cnpj,
                fornecedorViewModel.Telefone,
                fornecedorViewModel.Email,
                fornecedorViewModel.Endereco,
                fornecedorViewModel.Bairro,
                fornecedorViewModel.Complemento

                );

            return fornecedor;
        }

        public static IEnumerable<FornecedorViewModel> MapearListaFornecedorViewModel(IEnumerable<Fornecedor> fornecedores)
        {
            var lista = new List<FornecedorViewModel>();
            foreach (var item in fornecedores)
            {
                lista.Add(MapearFornecedorViewModel(item));
            }

            return lista;
        }
    }
}

