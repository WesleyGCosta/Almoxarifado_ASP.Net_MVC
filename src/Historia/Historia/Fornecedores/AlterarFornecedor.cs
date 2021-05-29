using Dominio.Entidades;
using Dominio.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historia.Fornecedores
{
    public class AlterarFornecedor
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public AlterarFornecedor(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        public async Task Executar(int id, Fornecedor fornecedor)
        {
            var dadosDoFornecedor = await _fornecedorRepository.BuscarPorId(id);

            dadosDoFornecedor.AtualizarFornecedor(
                fornecedor.Nome,
                fornecedor.RazaoSocial,
                fornecedor.Cnpj,
                fornecedor.Telefone,
                fornecedor.Email,
                fornecedor.Endereco,
                fornecedor.Bairro,
                fornecedor.Complemento
                );

            await _fornecedorRepository.Alterar(dadosDoFornecedor);
        }
    }
}
