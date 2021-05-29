using Dominio.Entidades;
using Dominio.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historia.Produtos
{
    public class CriarProduto
    {
        private readonly IProdutoRepository _produtoRepository;

        public CriarProduto(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Executar(Produto produto)
        {
            await _produtoRepository.Criar(produto);
        }
    }
}
