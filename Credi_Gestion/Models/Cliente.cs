using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Credi_Gestion.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del cliente es requerido")]
        public string NombreCliente { get; set; }

        [Required(ErrorMessage = "El número de cedula es requerido")]
        [StringLength(100)]

        public string Cedula { get; set; }

        [Required(ErrorMessage = "La dirección  es requerida")]
        [StringLength(100)]
        public string Direccion { get; set; }

        [StringLength(100)]
        public string Sexo { get;set;}

        [Required(ErrorMessage = "Debe ingresar el número de teléfono")]
        
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Debe ingresar el monto del préstamo")]
       
        public decimal Prestamo { get; set; }

        [Column(TypeName = "decimal(12, 2)")]
        [Required(ErrorMessage = "Debe ingresar el saldo")]
        public decimal Saldo { get; set; }

        [Required(ErrorMessage = "Debe seleccionar la fecha")]
        // guardar en la base de datos con fecha y hora
        [DataType(DataType.Date)]
        [Display(Name = "Fecha del registro")]
        public DateTime FechaReg { get; set; }

        public string UsuarioRe { get; set; }


    }
}
