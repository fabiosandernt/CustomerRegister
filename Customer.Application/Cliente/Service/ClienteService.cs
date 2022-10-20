using AutoMapper;
using Customer.Domain.Cadastro.Repository;
using static Customer.Application.Cliente.Dto.ClienteDto;

namespace Customer.Application.Cliente.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository empresaRepository, IMapper mapper)
        {
            this._clienteRepository = empresaRepository;
            this._mapper = mapper;
        }

        public async Task<ClienteOutputDto> Criar(ClienteInputDto dto)
        {
            if (await _clienteRepository.AnyAsync(x => x.Cpf == dto.Cfp)) 
                throw new Exception("Já existe um cliente cadastrado com o mesmo CPF");

            var cliente = this._mapper.Map<Customer.Domain.Cadastro.Cliente>(dto);
            await this._clienteRepository.Save(cliente);
            return this._mapper.Map<ClienteOutputDto>(cliente);
        }
        public async Task<ClienteOutputDto> Deletar(ClienteInputDto dto)
        {
            if (await _clienteRepository.AnyAsync(x => x.Cpf == dto.Cfp))
            {
                var empresa = this._mapper.Map<Customer.Domain.Cadastro.Cliente>(dto);
                
                await this._clienteRepository.Delete(empresa);
                return this._mapper.Map<ClienteOutputDto>(empresa);
            }
            else
            {
                throw new Exception("Este cliente não existe.");

            }
        }

        public async Task<ClienteOutputDto> Atualizar(ClienteInputDto dto)
        {
            if (await _clienteRepository.AnyAsync(x=>x.Cpf == dto.Cfp))
            {
                var cliente = this._mapper.Map<Customer.Domain.Cadastro.Cliente>(dto);
                await this._clienteRepository.Update(cliente);
                return this._mapper.Map<ClienteOutputDto>(cliente);
            }
            else
            {
                throw new Exception("Este cliente não existe.");
            }
        }
        public async Task<List<ClienteOutputDto>> ObterTodos()
        {
            var cliente = await this._clienteRepository.GetAll();
            return this._mapper.Map<List<ClienteOutputDto>>(cliente);
        }

        public async Task<ClienteOutputDto> ObterPorId(Guid id)
        {
            var cliente = await this._clienteRepository.Get(id);
            return this._mapper.Map<ClienteOutputDto>(cliente);
        }

       
    }

        
}
