using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projetWeb.client.Models
{
    public class Register
    {
        [Required(ErrorMessage = "Le nom est requis")]
        [Display(Name = "Nom")]
        [StringLength(50, ErrorMessage = "Le nom doit être plus petit que 50 characters")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Prénom")]
        [StringLength(50, ErrorMessage = "Prénom doit être plus petit que 50 characters")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Mot de passe")]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [Display(Name = "Confirmer Mot de passe")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Adresse email ")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail non valide")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Numéro de téléphone")]
        [Required(ErrorMessage = "Le numéro de téléphone est requis")]
        [StringLength(25, ErrorMessage = "Le numéro de téléphone doit être plus petit que 25 characters")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Professionnel")]
        public bool Professional { get; set; }
        
        [Required]
        [Display(Name = "Genre")]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Date de naissance ")]
        public DateTime BirthDate { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        NonBinary
    }
}
