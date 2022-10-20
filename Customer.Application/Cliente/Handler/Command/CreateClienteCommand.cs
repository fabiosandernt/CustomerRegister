using MediatR;
using static Customer.Application.Cliente.Dto.ClienteDto;

namespace Customer.Application.Cliente.Handler.Command
{
    public class CreateClinteCommand : IRequest<CreateClienteCommandResponse>
    {
        public ClienteInputDto Cliente { get; set; }

        public CreateClinteCommand(ClienteInputDto cliente)
        {
            Cliente = cliente;
        }
    }

    public class CreateClienteCommandResponse
    {
        public ClienteOutputDto Cliente { get; set; }

        public CreateClienteCommandResponse(ClienteOutputDto cliente)
        {
            Cliente = cliente;
        }
    }
}
