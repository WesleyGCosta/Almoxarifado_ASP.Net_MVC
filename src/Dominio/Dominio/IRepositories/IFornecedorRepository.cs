using Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.IRepositories
{
    public interface IFornecedorRepository
    {
        Task Criar(Fornecedor fornecedor);
        Task Alterar(Fornecedor fornecedor);
        Task Excluir(Fornecedor fornecedor);
        Task<Fornecedor> BuscarPorId(int id);
        Task<IEnumerable<Fornecedor>> ListarTodosFornecedores();

    }
}
