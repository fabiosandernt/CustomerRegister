using Customer.CrossCutting.Entity;
using Customer.Domain.Account;
using Customer.Domain.Cadastro.Enums;
using Customer.Domain.Cadastro.Rules;
using Customer.Domain.Cadastro.ValueObject;
using FluentValidation;
using System;
using System.Data;

namespace Customer.Domain.Cadastro
{
    public class Cliente : Entity<Guid>
    {
        protected Cliente() { }
        public string Nome { get; set; }       
        public Cpf Cpf { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime Nascimento { get; set; }
        public TipoSexoEnum Sexo { get; set; }
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public Cliente( string nome, Endereco endereco, Cpf cpf, TipoSexoEnum sexo, DateTime nascimento )
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Sexo = sexo;
            Endereco = endereco;
            Cpf = cpf;
            Nascimento = nascimento;
        }

        public readonly struct Idade
        {
            public Idade(DateTime idade)
            {
                if (idade.)
                {

                }
                return idade;
            }
        } 

    }
}
