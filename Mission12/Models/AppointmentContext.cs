using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission12.Models
{
    public class AppointmentContext : DbContext //inherits from dbcontext 
    {
        public AppointmentContext(DbContextOptions<AppointmentContext> options) : base(options)
        {
        }
        public DbSet<AppointmentInfo> Responses { get; set; } //connects and helps pull data from db

        protected override void OnModelCreating(ModelBuilder mb) //seeds data
        {
            mb.Entity<AppointmentInfo>().HasData(

                new AppointmentInfo
                {
                    TourId=1,
                    AptDate=DateTime.Now,
                    AptTime=20,
                    GroupName="A Group",
                    Size=12,
                    Email="randomEmail@gmail.com",
                    Phone="555-555-5555"

                });

        }
    }
}
