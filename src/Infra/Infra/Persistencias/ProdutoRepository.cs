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
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly DataContext _dataContext;

        public ProdutoRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Criar(Produto produto)
        {
            _dataContext.Produtos.Add(produto);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Alterar(Produto produto)
        {
            _dataContext.Update(produto);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Excluir(Produto produto)
        {
            _dataContext.Remove(produto);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<Produto> BuscarPorId(int id)
        {
            var produto = await _dataContext.Produtos.FirstOrDefaultAsync(x => x.Id == id);
            return produto;
        }

        public async Task<IEnumerable<Produto>> ListarTodosProdutos()
        {
            return await _dataContext.Produtos.AsNoTracking().ToListAsync();
        }
    }
}
