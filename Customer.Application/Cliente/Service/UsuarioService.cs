using AutoMapper;
using Customer.Application.Cliente.Dto;
using Customer.Domain.Account.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Application.Cliente.Service
{
    public class UsuarioService: IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        private readonly IJwtService _jwtService;

        public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper, IJwtService jwtService)
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
            _jwtService = jwtService;
        }

        public Task<UsuarioDto.UsuarioOutputDto> Atualizar(UsuarioDto.UsuarioInputDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioDto.UsuarioOutputDto> Criar(UsuarioDto.UsuarioInputDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioDto.UsuarioOutputDto> Deletar(UsuarioDto.UsuarioInputDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<UsuarioDto.UsuarioOutputDto> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UsuarioDto.UsuarioOutputDto>> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public Task<string> ObterTokenJwtAsync(LoginDto dto)
        {
            throw new NotImplementedException();
        }
    }

}
