using HotelProject.EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProjeDataAccesLayer.Concrate
{
  public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-JEPLJDD\\SQLEXPRESS;initial catalog=ApiOtelProje;integrated security=true");
        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Staff> Staffs { get; set;}
        public DbSet<Service> Services { get; set; }
        public DbSet<Subscribe> Subscriptions { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
    }
}
