using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplomado_MVC_5_3.Models.Entities
{
    public class Cliente
    {
        [Required]
        public int ClienteId { get; set; }

        [MinLength(3, ErrorMessage = "El Nombre debe tener mas de 3 caracteres...")]
        public string Nombres { get; set; }
        
        [MinLength(3, ErrorMessage = "El Apellido debe tener mas de 3 caracteres...")]
        public string Apellidos { get; set; }
        public string Direccion { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Movil { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
        
    }
}
