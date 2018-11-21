using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CapstoneProject.Models
{
    public class Profile : Artist
    {
        [Key]
        [Display(Name = "Name")]
        public string Name { get; set; }
      
        [Display(Name = "Bio")]
        public string Biography { get; set; }



    }
}