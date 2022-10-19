using Customer.Domain.Client;
using Customer.Domain.Client.Repository;
using Customer.Repository.Context;
using Customer.Repository.Database;
using Microsoft.EntityFrameworkCore;

namespace Customer.Repository.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(CustomerContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Cliente>> ObterTodosClientes()
        {
            return await this.Query.Include(x => x.Cpf).ToListAsync();
        }

        public async Task<IEnumerable<Cliente>> ObterTodosClientesPorCpf(string cpf)
        {
            return await this.Query.Where(x => x.Equals(cpf)).ToListAsync();
        }
    }
}
