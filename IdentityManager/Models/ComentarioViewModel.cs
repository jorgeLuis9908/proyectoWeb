using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Models
{
    public class ComentarioViewModel
    {

        [Required]
        
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]

        [Display(Name = "Comentario")]
        public string comentario { get; set; }

    }

}
