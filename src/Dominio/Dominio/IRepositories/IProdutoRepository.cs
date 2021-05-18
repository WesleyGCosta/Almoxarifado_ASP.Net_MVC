using Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.IRepositories
{
    public interface IProdutoRepository
    {
        Task<Produto> Criar(Produto produto);
        Task<Produto> Alterar(Produto produto);
        Task<Produto> Exluir(Produto produto);
        Task<Produto> BuscarPorId(int id);
        Task<IEnumerable<Produto>> ListarTodosProduto();

    }
}
