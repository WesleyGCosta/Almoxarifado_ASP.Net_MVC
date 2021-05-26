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
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataContext _dataContext;

        public ClienteRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Criar(Cliente cliente)
        {
            _dataContext.Clientes.Add(cliente);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Alterar(Cliente cliente)
        {
            _dataContext.Update(cliente);
            await _dataContext.SaveChangesAsync();
        }
        public async Task Excluir(Cliente cliente)
        {
            _dataContext.Remove(cliente);
            await _dataContext.SaveChangesAsync();
        }
        public async Task<Cliente> BuscarPorId(int id)
        {
            var cliente = await _dataContext.Clientes.FirstOrDefaultAsync(x => x.Id == id);
            return cliente;
        }

        public async Task<IEnumerable<Cliente>> ListarTodosClientes()
        {
            return await _dataContext.Clientes.AsNoTracking().ToListAsync();
        }

        
    }
}
