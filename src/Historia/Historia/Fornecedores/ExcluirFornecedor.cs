using Dominio.Entidades;
using Dominio.IRepositories;
using System.Threading.Tasks;

namespace Historia.Fornecedores
{
    public class ExcluirFornecedor
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public ExcluirFornecedor(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        public async Task Executar(Fornecedor fornecedor)
        {
            await _fornecedorRepository.Excluir(fornecedor);
        }
    }
}
