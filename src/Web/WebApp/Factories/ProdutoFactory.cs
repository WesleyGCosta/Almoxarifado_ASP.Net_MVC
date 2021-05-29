using Dominio.Entidades;
using System.Collections.Generic;
using WebApp.Models;

namespace WebApp.Factories
{
    public static class ProdutoFactory
    {
        public static ProdutoViewModel MapearProdutoViewModel(Produto produto)
        {
            var produtoViewModel = new ProdutoViewModel
            {
                Id = produto.Id,
                NomeDoProduto = produto.NomeDoProduto,
                Quantidade = produto.Quantidade,
                Preco = produto.Preco,
                Categoria = produto.Categoria,
                Fornecedor = produto.Fornecedor,
                Cnpj = produto.Cnpj,
                Descricao = produto.Descricao
            };
            return produtoViewModel;
        }

        public static Produto MapearProduto(ProdutoViewModel produtoViewModel)
        {
            var produto = new Produto(
                produtoViewModel.NomeDoProduto,
                produtoViewModel.Quantidade,
                produtoViewModel.Preco,
                produtoViewModel.Categoria,
                produtoViewModel.Cnpj,
                produtoViewModel.Descricao
                );

            return produto;
        }

        public static IEnumerable<ProdutoViewModel> MapearListaProdutoViewModel(IEnumerable<Produto> produtos)
        {
            var lista = new List<ProdutoViewModel>();
            foreach (var item in produtos)
            {
                lista.Add(MapearProdutoViewModel(item));
            }
            return lista;
        }
    }
}
