using Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dominio.IRepositories
{
    public interface IClienteRepository
    {
        Task Criar(Cliente cliente);
        Task Alterar(Cliente cliente);
        Task Excluir(Cliente cliente);
        Task<Cliente> BuscarPorId(int id);
        Task <IEnumerable<Cliente>> ListarTodosClientes();

    }
}
