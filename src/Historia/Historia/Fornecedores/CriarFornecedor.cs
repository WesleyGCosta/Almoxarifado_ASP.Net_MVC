using Dominio.Entidades;
using Dominio.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historia.Fornecedores
{
    public class CriarFornecedor
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public CriarFornecedor(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        public async Task Executar(Fornecedor fornecedor)
        {
            await _fornecedorRepository.Criar(fornecedor);
        }
    }
}
