using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Job_Offers_Website.Models
{
    public class Job
    {
        public int Id { get; set; }
        [DisplayName("Nom du poste")]
        public string JobTitle { get; set; }
        [DisplayName("Déscription du poste")]
        public string JobContent { get; set; }
        [DisplayName("Image du poste")]
        public string JobImage { get; set; }

        [DisplayName("Type du poste")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}