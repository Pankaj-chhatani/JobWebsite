using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Job_Offers_Website.Models
{
    public class Category
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Type du poste")]
        public string CategoryName { get; set; }
        [Required]
        [Display(Name = "Description du type")]
        public string CategoryDescription { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
    }
}