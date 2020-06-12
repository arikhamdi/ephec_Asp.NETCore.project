using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projetWeb.client.Models
{
    public class Establishment
    {

        [Required(ErrorMessage = "Establishment ID is required")]
        [Display(Name = "Establishment ID")]
        public int EstablishmentID { get; set; }

        [Display(Name = "Establishment Name")]
        [Required(ErrorMessage = "Establishment Name is required")]
        [StringLength(50, ErrorMessage = "Establishment Name must be less than 50 characters")]
        public string Name { get; set; }
    }
}
