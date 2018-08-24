using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SpotifyAPI.Web; //Base Namespace
using SpotifyAPI.Web.Auth; //All Authentication-related classes
using SpotifyAPI.Web.Enums; //Enums
using SpotifyAPI.Web.Models; //Models for the JSON-responses

//Database Context.
namespace EchoBox.Models
{
    public class EchoDb : DbContext
    {

        

        public DbSet<User> Users { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}