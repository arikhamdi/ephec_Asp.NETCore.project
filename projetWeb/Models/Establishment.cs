using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace projetWeb.Models
{
    [Table("Establishment")]
    public class Establishment
    {
        [Column("EstablishmentID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Establishment ID is required")]
        [Display(Name = "Establishment ID")]
        public int EstablishmentID { get; set; }

        [Display(Name = "Establishment Name")]
        [Required(ErrorMessage = "Establishment Name is required")]
        [StringLength(50, ErrorMessage = "Establishment Name must be less than 50 characters")]
        public string Name { get; set; }
        
        /*public string Type { get; set; }
        
        [Column("Vat")]
        [Display(Name = "T.V.A.")]
        [Required(ErrorMessage = "Vat is required")]
        public string Vat { get; set; }

        [Column("EmailPro")]
        [Display(Name = "Establishment ID")]
        [RegularExpression(@"^[a-zA-Z0-9\-'_]$")]
        [Required(ErrorMessage = "Email Pro Name is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailPro { get; set; }

        [Column("Description")]
        [Display(Name = "Description")]
        [StringLength(2000, ErrorMessage = "Description must be less than 2000 characters")]
        public string Description { get; set; }

        [Column("Logo")]
        [Display(Name = "Logo")]
        [Required(ErrorMessage = "Please select file.")]
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.gif)$", ErrorMessage = "Only Image files allowed.")]
        public IFormFile Logo { get; set; }

        // 
        //  Establishement info
        //


        [Column("PostalCode")]
        [Display(Name = "Code postal")]
        [Required(ErrorMessage = "PostalCode is required")]
        [StringLength(20, ErrorMessage = "PostalCode must be less than 20 characters")]
        public string PostalCode { get; set; }

        [Column("City")]
        [Display(Name = "Ville")]
        [Required(ErrorMessage = "PostalCode is required")]
        [StringLength(100, ErrorMessage = "PostalCode must be less than 100 characters")]
        public string City { get; set; }

        [Column("Country")]
        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country is required")]
        [StringLength(15, ErrorMessage = "Country must be less than 15 characters")]
        public string Country { get; set; }

        [Column("Street")]
        [Display(Name = "Rue")]
        [Required(ErrorMessage = "Street is required")]
        [StringLength(100, ErrorMessage = "Street must be less than 100 characters")]
        public string Street { get; set; }

        [Column("StreetNumber")]
        [Display(Name = "Numéro de Rue")]
        [Required(ErrorMessage = "StreetNumber is required")]
        [StringLength(20, ErrorMessage = "StreetNumber must be less than 20 characters")]
        public string StreetNumber { get; set; }

        [Column("PhoneNumber")]
        [Display(Name = "Numéro de Téléphone")]
        [Required(ErrorMessage = "StreetNumber is required")]
        [StringLength(20, ErrorMessage = "StreetNumber must be less than 20 characters")]
        public string PhoneNumber { get; set; }

        [Column("EstablishmentEmail")]
        [Display(Name = "Establishment Email")]
        [RegularExpression(@"^[a-zA-Z0-9\-'_]$")]
        [Required(ErrorMessage = "Establishment Email Pro Name is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        
        [Column("WebSite")]
        [Display(Name = "Site Internet")]
        [Url]
        public string WebSite { get; set; }

        [Column("Instagram")]
        [Display(Name = "Instagram")]
        [Url]
        public string Instagram { get; set; }

        [Column("Facebook")]
        [Display(Name = "Facebook")]
        [Url]
        public string Facebook { get; set; }

        [Column("Linkedin")]
        [Display(Name = "Linkedin")]
        [Url]
        public string Linkedin { get; set; }
        
        public string[] picture { get; set; }*/




    }
}
