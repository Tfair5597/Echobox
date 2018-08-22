using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;




namespace EchoBox.Models
{
    public class Genre //A genre of music.
    {
       //all genres listed in the genre seeds on spotify's developer site.
       

        [Key]
        public int GenreID { get; set; }

        [Required][Display(Name ="Genre")]
        public string GenreName { get; set; } //name of genre, such as Rock, Pop, Metal

        [Required][Display(Name="Description")]
        public string GenreDescription { get; set; }

        public string Instruments { get; set; } // common instruments in the genre. E.g. rock has guitar, bass, vocals.

        [Required][Display(Name ="Sub Genre")]
        public bool isSubGenre { get; set; }

    }
}