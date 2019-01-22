using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CapstoneProject.Models
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = " First Name ")]
        public string FirstName { get; set; }
        [Display(Name = " Last Name ")]
        public string LastName { get; set; }
        [Display (Name = "Age")]
        public int Age { get; set; }
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        [Display(Name = " Email ")]
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        [Display(Name = " Address ")]
        public string Address { get; set; }
        public int ZipCode { get; set; }
        [Display(Name = " User Name ")]
        public string UserName { get; set; }
        [Display(Name = "Bio")]
        public string Biography { get; set; }
        
    }
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string UserName { get; set; }
    }
}