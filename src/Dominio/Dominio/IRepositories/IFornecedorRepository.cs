using Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.IRepositories
{
    public interface IFornecedorRepository
    {
        Task<Fornecedor> Criar(Fornecedor fornecedor);
        Task<Fornecedor> Alterar(Fornecedor fornecedor);
        Task<Fornecedor> Excluir(Fornecedor fornecedor);
        Task<Fornecedor> BuscarPorId(int id);
        Task<IEnumerable<Fornecedor>> ListarTodosFornecedor();

    }
}
