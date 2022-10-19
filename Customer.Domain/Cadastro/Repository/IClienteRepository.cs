using Customer.CrossCutting.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Domain.Client.Repository
{
    public interface IClienteRepository: IRepository<Cliente>
    {
        Task<IEnumerable<Cliente>> ObterTodosClientes();
        Task<IEnumerable<Cliente>> ObterTodosClientesPorCpf(string cpf);
    }
}
