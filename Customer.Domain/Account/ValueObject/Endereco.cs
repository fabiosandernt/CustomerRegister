using Customer.Domain.Account.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Domain.Account.ValueObject
{
    public class Endereco
    {
        public EnumEstado Estado { get; set; }
        public string Cidade { get; set; }


    }
}
