using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Credi_Gestion.Models
{    
    public class Prestamo
    {
        [Key]
        public int IdPrestamo { get; set; }


        public int IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public Cliente Cliente { get; set; }

        [Column(TypeName = "Decimal(12, 2)")]
        public  decimal Monto {get;set;}

        public string Moneda { get; set; }

        [Column(TypeName = "Decimal(12, 2)")]
        public decimal interes { get; set; }
        [Column(TypeName = "Decimal(12, 2)")]
        public decimal MontoTotal { get; set; }

        [Column(TypeName = "Decimal(12, 2)")]
        public decimal Plazo { get;set;}

        [Column(TypeName = "Decimal(12, 2)")]
        public decimal Saldo { get;set;}

 
        public DateTime FechaReg { get; set; }

        public string UsuarioRe { get; set; }

        public string Estado { get; set; }


       

    }

}
