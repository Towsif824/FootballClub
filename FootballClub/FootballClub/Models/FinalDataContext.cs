using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FootballClub.Models
{
    public class FinalDataContext: DbContext
    {
        public FinalDataContext()
        {
            Database.SetInitializer<FinalDataContext>(new DropCreateDatabaseIfModelChanges<FinalDataContext>());
        }

        virtual public DbSet<Signup> signups { get; set; }
        virtual public DbSet<Player> players { get; set; }
    }
}