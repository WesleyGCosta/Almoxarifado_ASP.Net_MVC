using Dominio.Entidades;
using Dominio.IRepositories;
using System.Threading.Tasks;

namespace Historia.Produtos
{
    public class AlterarProduto
    {
        private readonly IProdutoRepository _produtoRepository;

        public AlterarProduto(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Executar(int id, Produto produto)
        {
            var dadosDoProduto = await _produtoRepository.BuscarPorId(id);

            dadosDoProduto.AtualizarProduto(
                produto.NomeDoProduto, 
                produto.Quantidade, 
                produto.Preco, 
                produto.Categoria, 
                produto.Cnpj
                );

            await _produtoRepository.Alterar(produto);
        }
    }
}
