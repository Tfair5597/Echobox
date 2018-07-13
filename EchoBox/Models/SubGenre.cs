using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EchoBox.Models
{
    public class SubGenre
    {
        [Key]
        public int SubGenreID { get; set; }

        [Display(Name ="Sub genre")][Required]
        public string SubGenreName { get; set; } // name of sub genre e.g. thrash metal, pop punk

        [Display(Name="Parent Genre")]
        public string ParentGenre1 { get; set; } //name of the parent genre. e.g. pop punk is derived from a mix of pop music and punk music.

        [Display(Name ="Parent Genre 2")]
        public string ParentGenre2 { get; set; }  // same as above, nullable.

        [Required]
        [Display(Name = "Sub genre description")]
        public string SubGenreDescription { get; set; } //description of sub genre.
    }
}

//example of a subgenre: House music, a subgenre of techno. House features kick drums every beat while techno replaces that with a bass drum
//every beat. BPM for house is typically 118 to 135, while techno's range is 130 to 150 bpm.
//example taken from here: https://www.diffen.com/difference/House_Music_vs_Techno_Music