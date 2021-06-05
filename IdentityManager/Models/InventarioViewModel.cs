using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Models
{
    public class InventarioViewModel
    {

        [Required]
        
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]

        [Display(Name = "Cantidad")]
        public string Cantidad { get; set; }

        [Required]

        [Display(Name = "Precio")]
        public string precio { get; set; }

        [Required]

        [Display(Name = "Codigo")]
        public string Codigo { get; set; }
    }

}
