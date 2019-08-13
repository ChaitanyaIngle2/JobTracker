using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobTracker.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public Status Status { get; set; }
        public int StatusId { get; set; }
    }
}