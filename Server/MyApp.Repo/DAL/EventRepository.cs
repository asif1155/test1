using MyApp.DAL;
using MyApp.DAL.Models;
using MyApp.DTO.ViewModels;
using MyApp.Repo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyApp.Repo.DAL.Repository
{
    public class EventRepository : IRepository<EventVM>
    {
        DataDbContext db;

        public EventRepository(DataDbContext _db)
        {
            db = _db;
        }

        public EventVM Add(EventVM cvm)
        {
            Event obj = new Event();
            obj.UserID = cvm.UserID;
            obj.Title = cvm.Title;
            obj.Description =cvm.Description;
            obj.Location = cvm.Location;
            obj.NotifyBefore = cvm.NotifyBefore;
            obj.Label = cvm.Label;
            obj.EventDate = cvm.EventDate;
            obj.StartTime = cvm.StartTime;
            obj.EndTime = cvm.EndTime;

            db.Event.Add(obj);
            db.SaveChanges();
            cvm.ID = obj.ID;
            return cvm;
        }

        public EventVM Get(long id)
        {
            EventVM SingleEvent = db.Event.Select(cvm => new EventVM
            {
                ID = cvm.ID,
                UserID = cvm.UserID,
                Title = cvm.Title,
                Description = cvm.Description,
                Location = cvm.Location,
                NotifyBefore = cvm.NotifyBefore,
                Label = cvm.Label,
                EventDate = cvm.EventDate,
                StartTime = cvm.StartTime,
                EndTime = cvm.EndTime
        }).Where(q => q.ID == id).FirstOrDefault();
            return SingleEvent;
        }

        public IEnumerable<EventVM> GetAll()
        {
            IEnumerable<EventVM> data = db.Event.Select(cvm => new EventVM
            {
                ID = cvm.ID,
                UserID = cvm.UserID,
                Title = cvm.Title,
                Description = cvm.Description,
                Location = cvm.Location,
                NotifyBefore = cvm.NotifyBefore,
                Label = cvm.Label,
                EventDate = cvm.EventDate,
                StartTime = cvm.StartTime,
                EndTime = cvm.EndTime
            });
            return data;
        }    

        public bool Remove(long id)
        {
            Event c = db.Event.Where(q => q.ID == id).SingleOrDefault(); //.Find(id);
            db.Event.Remove(c);
            db.SaveChanges();
            return true;
        }

        public bool Remove(EventVM cvm)
        {
            Event c = db.Event.Find(cvm.ID);
            db.Event.Remove(c);
            db.SaveChanges();
            return true;
        }

        public EventVM Update(EventVM cvm)
        {
            Event obj = db.Event.Find(cvm.ID);
            obj.UserID = cvm.UserID;
            obj.Title = cvm.Title;
            obj.Description = cvm.Description;
            obj.Location = cvm.Location;
            obj.NotifyBefore = cvm.NotifyBefore;
            obj.Label = cvm.Label;
            obj.EventDate = cvm.EventDate;
            obj.StartTime = cvm.StartTime;
            obj.EndTime = cvm.EndTime;

            db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return cvm;
        }
    }//c
}//ns