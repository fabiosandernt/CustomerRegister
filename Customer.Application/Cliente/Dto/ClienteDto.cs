using Customer.Domain.Cadastro.Enums;
using Customer.Domain.Cadastro.ValueObject;
using System.Data;

namespace Customer.Application.Cliente.Dto
{
    public class ClienteDto
    {
        public record ClienteInputDto(string Nome, Cpf Cfp, Endereco Endereco, TipoSexoEnum Sexo, DateTime Nascimento);
        public record ClienteOutputDto(Guid Id, string Nome, Cpf Cfp, Endereco Endereco, TipoSexoEnum Sexo, DateTime Nascimento);
    }
}
