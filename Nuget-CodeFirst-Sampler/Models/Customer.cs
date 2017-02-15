using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Nuget_CodeFirst_Sampler.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Name { get; set; }

        [Required, StringLength(30)]
        public string Surname { get; set; }

        [EmailAddress, StringLength(50)]
        public string Email { get; set; }

        public DateTime Birthdate { get; set; }
    }
}