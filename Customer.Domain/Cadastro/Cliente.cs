using Customer.CrossCutting.Entity;
using Customer.Domain.Account.ValueObject;


namespace Customer.Domain.Cadastro
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
