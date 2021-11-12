using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoWebApi.Models
{
    public class Proyecto
    {
        [Key]
        public string Usuario { get; set; } //POSIBLE CAMBIO
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        public string Contraseña { get; set; }//POSIBLE CAMBIO
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "La longitud de {0} debe estar entre {2} y {1}")]
        public string Sintoma { get; set; } //POSIBLE CAMBIO
        [Url]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "La longitud de {0} debe estar entre {2} y {1}")]
        public string Enlace { get; set; }
    }
}
