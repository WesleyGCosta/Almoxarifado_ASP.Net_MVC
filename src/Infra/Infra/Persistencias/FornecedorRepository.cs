using Dominio.Entidades;
using Dominio.IRepositories;
using Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Persistencias
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly DataContext _dataContext;

        public FornecedorRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Criar(Fornecedor fornecedor)
        {
            _dataContext.Fornecedores.Add(fornecedor);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Alterar(Fornecedor fornecedor)
        {
            _dataContext.Update(fornecedor);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Excluir(Fornecedor fornecedor)
        {
            _dataContext.Remove(fornecedor);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<Fornecedor> BuscarPorId(int id)
        {
            var fornecedor = await _dataContext.Fornecedores.FirstOrDefaultAsync(x => x.Id == id);
            return fornecedor;
        }

        public async Task<IEnumerable<Fornecedor>> ListarTodosFornecedores()
        {
            return await _dataContext.Fornecedores.AsNoTracking().ToListAsync();
        }
    }
}
