using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.DAL.Models
{
    public class Event
    {
        public int ID { get; set; }
        public Guid UserID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Location { get; set; }
        public int NotifyBefore { get; set; }
        public string Label { get; set; }
        //public bool Status { get; set; }
    }//c
}//ns
