using Microsoft.EntityFrameworkCore;
using MyApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.DAL.DbContext
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().HasData(
                new Event { ID = 1, UserID = new Guid("a18be9c0-aa65-4af8-bd17-00bd9344e575"), Title= "Book events", Description= "Book publication ceremony", Location= "Bookstore",
                    EventDate=DateTime.Now, StartTime=DateTime.Now.AddHours(5), EndTime=DateTime.Now.AddHours(6), NotifyBefore=30, Label="" },
                new Event { ID = 2, UserID = new Guid("a18be9c0-aa65-4af8-bd17-00bd9344e575"), Title= "Marketing channels", Description= "Discuss current marketing trends", Location= "Business center",
                    EventDate=DateTime.Now, StartTime=DateTime.Now.AddHours(7), EndTime=DateTime.Now.AddHours(8), NotifyBefore=30, Label="" },
                new Event { ID = 3, UserID = new Guid("a18be9c0-aa65-4af8-bd17-00bd9344e575"), Title= "Event Planners", Description= "Plan for an event", Location= "Restaurant",
                    EventDate=DateTime.Now, StartTime=DateTime.Now.AddHours(10), EndTime=DateTime.Now.AddHours(11), NotifyBefore=30, Label="" }
            );        
  
        }
    }
}
