using Dominio.Entidades;
using Dominio.IRepositories;
using System.Threading.Tasks;

namespace Historia.Produtos
{
    public class ExcluirProduto
    {
        private readonly IProdutoRepository _produtoRepository;

        public ExcluirProduto(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Executar(Produto produto)
        {
            await _produtoRepository.Excluir(produto);
        }
    }
}
