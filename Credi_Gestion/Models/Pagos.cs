using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;


namespace Credi_Gestion.Models
{
    public class Pagos
    {
        [Key]
        public int Id_Pago { get; set; }

        [Column(TypeName = "Decimal(12, 2)")]
        public decimal MontoPagado { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaPago { get; set; }

        [Column(TypeName = "Decimal(12, 2)")]
        public decimal Saldo { get; set; }

        public string UsuarioRe { get; set; }

        [ForeignKey("IdPrestamo")]
        public Prestamo Prestamo { get; set; }
    }
}
