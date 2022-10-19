using Customer.Domain.Account.Enums;
using Customer.Domain.Account.ValueObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Application.Cliente.Dto
{
    public class UsuarioDto
    {
        public record UsuarioInputDto(
        Guid? Id,
        [Required(ErrorMessage = "O nome é requerido!")] string Name,
        [Required(ErrorMessage = "o Tipo é requerido!")] TipoUsuarioEnum TipoUsuario,
        [Required(ErrorMessage = "A Senha é requerida!")] Password Password,
        [Required(ErrorMessage = "O Email é requerido!")] Email Email
    );

        public record UsuarioOutputDto(Guid Id, string Name, TipoUsuarioEnum TipoUsuario, Email Email);
    }
}
