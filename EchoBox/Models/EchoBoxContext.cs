using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

//Database Context.
namespace EchoBox.Models
{
    public class EchoBox : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}