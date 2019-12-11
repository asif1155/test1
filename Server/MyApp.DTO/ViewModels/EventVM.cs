using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyApp.DTO.ViewModels
{
    public class EventVM
    {
        public int ID { get; set; }
        public Guid UserID { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime EventDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Location { get; set; }
        public int NotifyBefore { get; set; }
        public string Label { get; set; }
        //public bool Status { get; set; }

    }//c
}//ns
