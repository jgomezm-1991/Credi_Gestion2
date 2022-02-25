using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Credi_Gestion.Models
{    
    public class Prestamo
    {
        public int Id_Prestamo { get; set; }

       
        [Column(TypeName = "Decimal(12, 2)")]
        public  decimal Monto {get;set;}

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


        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }

    }

}
