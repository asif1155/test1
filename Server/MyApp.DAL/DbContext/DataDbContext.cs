using Microsoft.EntityFrameworkCore;
using MyApp.DAL.DbContext;
using MyApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.DAL
{
    public class DataDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> Options) : base(Options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }        
        public DbSet<Event> Event { get; set; }
      
    }//c

}//ns
