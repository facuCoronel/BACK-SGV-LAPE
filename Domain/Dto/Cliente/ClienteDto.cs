using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto.Cliente
{
    public class ClienteDto
    {
        public string NombreCliente { get; set; }
        public string Email { get; set; }
        public string TelefonoFijo { get; set; }
        public string Celular { get; set; }
    }
}
