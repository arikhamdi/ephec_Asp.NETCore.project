using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projetWeb.client.Models
{
    public class SignIn
    {
        [Required]
        [Display(Name = "Nom d'utilisateur")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Mot de Passe")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Rester connecté")]
        public bool RememberMe { get; set; }
    }
}
