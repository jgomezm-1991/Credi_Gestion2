using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Credi_Gestion.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "El nombre del cliente es requerido")]


        [StringLength(100)]

        public string NombreCliente { get; set; }


        [StringLength(100)]
        public string Apellidos {get ; set;}

        [Required(ErrorMessage = "El número de cedula es requerido")]
        [StringLength(100)]

        public string Cedula { get; set; }

        [Required(ErrorMessage = "La dirección  es requerida")]
        [StringLength(100)]
        public string Direccion { get; set; }

        [StringLength(100)]
        public string Genero { get;set;}

        [Required(ErrorMessage = "Debe ingresar el número de teléfono")]
        
        public string Telefono { get; set; }

        [StringLength(100)]
        public string Estado { get; set; }




       
        public DateTime FechaReg { get; set; }

        public string IdUsuario { get; set; }


    }
}
