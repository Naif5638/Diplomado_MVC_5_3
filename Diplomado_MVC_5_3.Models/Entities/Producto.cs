using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplomado_MVC_5_3.Models.Entities
{
    public class Producto
    {
        [Required(ErrorMessage = "Debe ingresar un id de Producto...")]
        public int ProductoId { get; set; }

        [Display(Name = "Producto")]
        [MinLength(3, ErrorMessage = "El producto debe tener mas de 3 caracteres...")]
        public string Product { get; set; }

        [MinLength(3, ErrorMessage = "La descripcion debe tener mas de 3 caracteres...")]
        public string Descripcion { get; set; }
                
        public float Precio { get; set; }
        public int CantExistencia { get; set; }
        public string ImageUrl { get; set; }
    }
}
