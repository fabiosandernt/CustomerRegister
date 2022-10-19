using Customer.CrossCutting.Entity;
using Customer.Domain.Account.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Domain.Client
{
    public class Cliente : Entity<Guid>
    {
        public string Nome { get; set; }
        public Cpf Cpf { get; set; }
        public Endereco Endereco { get; set; }
        public Cliente(string nome, Endereco endereco, Cpf cpf)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Endereco = endereco;
            Cpf = cpf;
        }
    }
}
