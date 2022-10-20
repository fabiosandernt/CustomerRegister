using Customer.CrossCutting.JwtService.Dto;
using Customer.CrossCutting.JwtService.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.CrossCutting.JwtService.Contracts
{
    public interface IJwtService
    {
        ValueTask<string> GenerateToken(JwtDto jwtDto);
        ValueTask<JwtTokenViewModel> ReadTokenAsync(string token);
    }
}
