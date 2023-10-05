using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventarios.Modelos
{
    public class Bodega
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage ="Nombre es Requerido")]
        [MaxLength(60,ErrorMessage ="Nombre debe ser Maximo 60 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Descripcion es Requerido")]
        [MaxLength(100, ErrorMessage = "Nombre debe ser Maximo 100 caracteres")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El estado es Requerido")]
        public bool Estado { get; set;}

    }
}
