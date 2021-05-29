using Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.IRepositories
{
    public interface IProdutoRepository
    {
        Task Criar(Produto produto);
        Task Alterar(Produto produto);
        Task Excluir(Produto produto);
        Task<Produto> BuscarPorId(int id);
        Task<IEnumerable<Produto>> ListarTodosProdutos();

    }
}
