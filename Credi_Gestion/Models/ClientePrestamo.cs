using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Credi_Gestion.Models
{
    public class ClientePrestamo
    {
        public ClientePrestamo()
        {
            Clientes = new List<Cliente>();
            Prestamos = new List<Prestamo>();
        }
        public List<Cliente> Clientes { get; set; }

        public List<Prestamo> Prestamos { get; set; }
    }
}

