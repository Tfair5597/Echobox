using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EchoBox.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string fName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string lName { get; set; }

        [Required]
        [Display(Name = "Birthdate")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Favorite genre")]
        public string FavGenre1 { get; set; }

        [Display(Name = "Favorite Genre 2")]
        public string FavGenre2 { get; set; }

        [Display(Name = "Favorite Genre 3")]
        public string FavGenre3 { get; set; }

        [Display(Name = "Favorite Genre 4")]
        public string FavGenre4 { get; set; }
    }
}