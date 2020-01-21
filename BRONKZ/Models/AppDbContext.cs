using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRONKZ.Models
{
    public class AppDbContext  : IdentityDbContext<Users>
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Users> AppUsers { get; set; }
        public DbSet<Renters> Renters { get; set; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Districts> Districts { get; set; }

        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<ApartmentFeatures> ApartmentFeatures { get; set; }
        public DbSet<ApartmentOptions> ApartmentOptions { get; set; }
        public DbSet<ApartmentRules> ApartmentRules { get; set; }
        public DbSet<ApartmentComforts> ApartmentComforts { get; set; }
    
    }
}
