using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Assessment2___Final.Models
{
    public class ClickPollDB : DbContext
    {
        public ClickPollDB() : base("DefaultConnection")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ClickPollDB>());
        }

        public DbSet<Cause> Causes { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Signature> Signatures { get; set; }

    }
}