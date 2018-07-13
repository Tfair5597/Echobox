using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EchoBox.Models
{
    public class Genre //A genre of music.
    {
        [Key]
        public int GenreID { get; set; } 
        [Required]
        public string GenreName { get; set; } //name of genre, such as Rock, Pop, Metal
        [Required]
        public string GenreDescription { get; set; } //description of genre, such as its' characteristics or common instruments.
    }
}