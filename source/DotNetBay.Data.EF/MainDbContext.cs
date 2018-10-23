using DotNetBay.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DotNetBay.Data.EF
{
    class MainDbContext : DbContext
    {
        public MainDbContext(): base("DatabaseConnection")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Auction>().HasRequired(a => a.Seller).WithMany(m => m.Auctions);

            modelBuilder.Conventions.Add(new DateTime2Convention());
        }


    }
}
