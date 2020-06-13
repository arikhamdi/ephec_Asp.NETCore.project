using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace projetWeb.client.Models
{
    public class Establishment
    {

        [Required]
        [Display(Name = "Identifiant")]
        public int EstablishmentID { get; set; }

        [Display(Name = "Nom du commerce")]
        [Required(ErrorMessage = "Le nom est requis")]
        [StringLength(50, ErrorMessage = "Le nom doit être plus petit que 50 characters")]
        public string Name { get; set; }

        [Display(Name = "Type")]
        [Required]
        public string EstablishmentType { get; set; }

        [Display(Name = "T.V.A.")]
        [Required(ErrorMessage = "Le Numéro de TVA est requis")]
        public string Vat { get; set; }

        [Display(Name = "Email Pro")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail non valide")]
        [Required(ErrorMessage = "Email Pro est requis")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailPro { get; set; }

        [Display(Name = "Description")]
        [StringLength(2000, ErrorMessage = "Description doit être plus petit que 2000 characters")]
        public string Description { get; set; }

        [Display(Name = "Logo")]
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif)$", ErrorMessage = "Fichier image uniquement.")]
        public string Logo { get; set; }

        // 
        //  Establishement info
        //

        [Display(Name = "Rue")]
        [Required(ErrorMessage = "Rue est requis")]
        [StringLength(100, ErrorMessage = "Rue doit être plus petit que 100 characters")]
        public string Street { get; set; }
        
        [Display(Name = "Numéro de Rue")]
        [Required(ErrorMessage = "Numéro de Rue est requis")]
        [StringLength(20, ErrorMessage = "Numéro de Rue doit être plus petit que 20 characters")]
        public string StreetNumber { get; set; }

        [Display(Name = "Code postal")]
        [Required(ErrorMessage = "Code postal est requis")]
        [StringLength(20, ErrorMessage = "Code postal doit être plus petit que 20 characters")]
        public string PostalCode { get; set; }

        [Display(Name = "Ville")]
        [Required(ErrorMessage = "Ville est requis")]
        [StringLength(100, ErrorMessage = "Ville doit être plus petit que 20 characters")]
        public string City { get; set; }

        [Display(Name = "Pays")]
        [Required(ErrorMessage = "Pays est requis")]
        [StringLength(15, ErrorMessage = "Pays doit être plus petit que 15 characters")]
        public string Country { get; set; }
        
        [Display(Name = "Numéro de Téléphone")]
        [Required(ErrorMessage = "Le numéro de téléphone est requis")]
        [StringLength(20, ErrorMessage = "Le numéro de téléphone doit être plus petit que 25 characters")]
        public string PhoneNumber { get; set; }


        [Display(Name = " Email")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail non valide")]
        [Required(ErrorMessage = "Email est requis")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EstablishmentEmail { get; set; }

        [Display(Name = "Site Internet")]
        [Url]
        public string WebSite { get; set; }


        [Display(Name = "Instagram")]
        [Url]
        public string Instagram { get; set; }


        [Display(Name = "Facebook")]
        [Url]
        public string Facebook { get; set; }


        [Display(Name = "Linkedin")]
        [Url]
        public string Linkedin { get; set; }
    }

    public enum EstablishmentType
    {
        Bar,
        NightClub,
        Concert,
        StudentCircle
    }
}
