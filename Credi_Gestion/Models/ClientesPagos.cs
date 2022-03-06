using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Credi_Gestion.Models
{
    public class ClientesPagos  
    {
        public ClientesPagos()
        {

            Clientes = new List<Cliente>();

            //Prestamos = new List<Prestamo>();
            //Pagos = new List<Pagos>();

        }
        public List<Cliente> Clientes { get; set; }
        public List<Cliente> Prestamos { get; set; }
        public List<Cliente> Pagos { get; set; }

    }
}
