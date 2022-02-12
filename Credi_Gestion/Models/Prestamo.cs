using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Credi_Gestion.Models
{
    public class Prestamo
    {
        public int Id { get; set; }

        public int ClienteId {get;set;}
        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }   
        

        [required]
        [Column(TypeName = "Decimal(12, 2)")]
        public  Decimal Monto {get;set;}


        [Column(TypeName = "Decimal(12, 2)")]
        public decimal Plazo { get;set;}

        [Column(TypeName = "Decimal(12, 2)")]
        public decimal Saldo { get;set;}

        [Required(ErrorMessage = "Debe seleccionar la fecha")]
        // guardar en la base de datos con fecha y hora
        [DataType(DataType.Date)]
        [Display(Name = "Fecha del registro")]
        public DateTime FechaReg { get; set; }

        [Display(Name = "Usuario que registró")]
        public string UsuarioRe { get; set; }

    }

}
