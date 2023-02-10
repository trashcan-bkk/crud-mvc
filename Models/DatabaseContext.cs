using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace crud_mvc.Models
{
    public class DatabaseContext : DbContext
    {
       public DatabaseContext()
        {

        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {

        }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Account> Accouunts { get; set; }
    }

    
}
