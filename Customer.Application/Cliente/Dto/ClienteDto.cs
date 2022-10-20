using Customer.Domain.Account.ValueObject;


namespace Customer.Application.Cliente.Dto
{
    public class ClienteDto
    {
        public record ClienteInputDto(string Nome, Cpf Cfp, Endereco Endereco);
        public record ClienteOutputDto(Guid Id, string Nome, Cpf Cfp, Endereco Endereco);
    }
}
