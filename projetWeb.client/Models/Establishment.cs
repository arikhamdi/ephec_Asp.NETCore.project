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

        [Required(ErrorMessage = "Establishment ID is required")]
        [Display(Name = "Establishment ID")]
        public int EstablishmentID { get; set; }

        [Display(Name = "Establishment Name")]
        [Required(ErrorMessage = "Establishment Name is required")]
        [StringLength(50, ErrorMessage = "Establishment Name must be less than 50 characters")]
        public string Name { get; set; }

        public string Type { get; set; }

        [Display(Name = "T.V.A.")]
        [Required(ErrorMessage = "Vat is required")]
        public string Vat { get; set; }

        [Display(Name = "Email Pro")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [Required(ErrorMessage = "Email Pro Name is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailPro { get; set; }

        [Display(Name = "Description")]
        [StringLength(2000, ErrorMessage = "Description must be less than 2000 characters")]
        public string Description { get; set; }

        [Display(Name = "Logo")]
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif)$", ErrorMessage = "Only Image files allowed.")]
        public string Logo { get; set; }

        // 
        //  Establishement info
        //

        [Display(Name = "Rue")]
        [Required(ErrorMessage = "Street is required")]
        [StringLength(100, ErrorMessage = "Street must be less than 100 characters")]
        public string Street { get; set; }
        
        [Display(Name = "Numéro de Rue")]
        [Required(ErrorMessage = "StreetNumber is required")]
        [StringLength(20, ErrorMessage = "StreetNumber must be less than 20 characters")]
        public string StreetNumber { get; set; }

        [Display(Name = "Code postal")]
        [Required(ErrorMessage = "PostalCode is required")]
        [StringLength(20, ErrorMessage = "PostalCode must be less than 20 characters")]
        public string PostalCode { get; set; }

        [Display(Name = "Ville")]
        [Required(ErrorMessage = "PostalCode is required")]
        [StringLength(100, ErrorMessage = "PostalCode must be less than 100 characters")]
        public string City { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country is required")]
        [StringLength(15, ErrorMessage = "Country must be less than 15 characters")]
        public string Country { get; set; }
        
        [Display(Name = "Numéro de Téléphone")]
        [Required(ErrorMessage = "Phone Number is required")]
        [StringLength(20, ErrorMessage = "StreetNumber must be less than 20 characters")]
        public string PhoneNumber { get; set; }


        [Display(Name = "Establishment Email")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [Required(ErrorMessage = "Establishment Email Pro Name is required")]
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
}
