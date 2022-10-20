
using static Customer.Application.Cliente.Dto.ClienteDto;

namespace Customer.Application.Cliente.Service
{
    public interface IClienteService
    {
        Task<ClienteOutputDto> Criar(ClienteInputDto dto);
        Task<List<ClienteOutputDto>> ObterTodos();
        Task<ClienteOutputDto> Atualizar(ClienteInputDto dto);
        Task<ClienteOutputDto> Deletar(ClienteInputDto dto);
        Task<ClienteOutputDto> ObterPorId(Guid id);
    }
}
