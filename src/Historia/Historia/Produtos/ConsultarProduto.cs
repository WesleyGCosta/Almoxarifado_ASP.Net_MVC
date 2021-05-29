using Dominio.Entidades;
using Dominio.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historia.Produtos
{
    public class ConsultarProduto
    {
        private readonly IProdutoRepository _produtoRepository;

        public ConsultarProduto(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<Produto> BuscarPorId(int id)
        {
            return await _produtoRepository.BuscarPorId(id);
        }

        public async Task<IEnumerable<Produto>> ListarTodosProdutos()
        {
            return await _produtoRepository.ListarTodosProdutos();
        }
    }
}
