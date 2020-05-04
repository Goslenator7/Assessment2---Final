/*using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Assessment2___Final.Models;


namespace Assessment2___Final.Data
{
    public class Assessment2___FinalDBContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx



        public Assessment2___FinalDBContext() : base("name=Assessment2___FinalDBContext")
        {
            // Call Initializer to seed database
            //Database.SetInitializer<Assessment2___FinalDBContext>(new Assessment2___FinalDBInitializer<Assessment2___FinalDBContext>());
        }
        public DbSet<Models.Cause> Causes { get; set; }
        public DbSet<Models.User> Users { get; set; }

        public DbSet<Models.Signature> Signatures { get; set; } 

        //Creating DB Initializer for seed
        private class Assessment2___FinalInitializer<T> : DropCreateDatabaseIfModelChanges<Assessment2___FinalDBContext>
        {
            protected override void Seed(Assessment2___FinalDBContext context)
            {
                context.Causes.Add(new Cause
                {
                    Title = "Stop Politics!",
                    Category = "Politics",
                    Description = "Politics must be stopped! It's too political!"
                });


                base.Seed(context);
            }
        }
    }
}*/
