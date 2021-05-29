using Dominio.Entidades;
using Dominio.IRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Historia.Fornecedores
{
    public class ConsultarFornecedor
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public ConsultarFornecedor (IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        public async Task<Fornecedor> BuscarPorId(int id)
        {
            return await _fornecedorRepository.BuscarPorId(id);
        }

        public async Task<IEnumerable<Fornecedor>> ListarTodosFornecedores()
        {
            return await _fornecedorRepository.ListarTodosFornecedores();
        }
    }
}
