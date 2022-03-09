using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Credi_Gestion.Models
{
    public class Pago
    {
        [Key]
        public int IdPago { get; set; }

        [Column(TypeName = "Decimal(12, 2)")]
        public decimal MontoPagado { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaPago { get; set; }

        [Column(TypeName = "Decimal(12, 2)")]
        public decimal Saldo { get; set; }

        public string UsuarioRe { get; set; }

        //[ForeignKey("IdPrestamo")]
        //public Prestamo prestamo { get; set; }

        public int IdPrestamo { get; set; }
        [ForeignKey("IdPrestamo")]
        public Prestamo Prestamo { get; set; }


    }
}
