using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productos.Shared.Modelos
{
    public class Productos
    {
        [Required(ErrorMessage = "El campo {0} es obbligatorio")]
        [Range (1,100000000, ErrorMessage="Ingresa un número válido")]
        public int? Inventario { get; set; }
        [Required(ErrorMessage = "El campo {0} es obbligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El campo {0} es obbligatorio")]
        public string? Departamento { get; set; }

    }
}