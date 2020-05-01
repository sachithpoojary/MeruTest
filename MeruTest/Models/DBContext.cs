using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Threading.Tasks;

namespace MeruTest.Models
{
    public class DBContext : DbContext
    {

        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<SubArea> SubAreas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Customer>()
                .HasData(new Customer
                {
                    CustId = 1,
                    CustName = "Sachith",
                    Address = "Malad",
                    CustMobNo = "1234567890",
                    SubAreaId = 1
                });
            builder.Entity<Customer>()
                .HasData(new Customer
                {
                    CustId = 2,
                    CustName = "Suyash",
                    Address = "Andheri",
                    CustMobNo = "1472583690",
                    SubAreaId = 2
                });
            builder.Entity<Customer>()
                .HasData(new Customer
                {
                    CustId = 3,
                    CustName = "Jeetu",
                    Address = "Kurla",
                    CustMobNo = "7894561230",
                    SubAreaId = 2
                });

            builder.Entity<City>()
                .HasData(new City
                {
                    CityId = 1,
                    CityName = "Mumbai",
                    State = "MH"
                });
            builder.Entity<City>()
                .HasData(new City
                {
                    CityId = 2,
                    CityName = "Banglore",
                    State = "KAR"
                });

            builder.Entity<Area>()
                .HasData(new Area
                {
                    AreaId = 1,
                    AreaName = "West",
                    CityId = 1
                });
            builder.Entity<Area>()
                .HasData(new Area
                {
                    AreaId = 2,
                    AreaName = "South",
                    CityId = 2
                });

            builder.Entity<SubArea>()
                .HasData(new SubArea
                {
                    SubAreaId = 1,
                    SubAreaName = "South West",
                    AreaId = 1
                });
            builder.Entity<SubArea>()
                .HasData(new SubArea
                {
                    SubAreaId = 2,
                    SubAreaName = "South",
                    AreaId = 2
                });
        }
    }
}
