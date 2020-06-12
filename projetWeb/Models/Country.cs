using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace projetWeb.Models
{
    [Table("Country")]
    public class Country
    {
        [Column("CountryID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CountryID { get; set; }

        [Required]
        [StringLength(80)]
        public string Name { get; set; }
    }
}
