using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobTracker.Models
{
    public class Job
    {
        public String Company { get; set; }
        public String Position { get; set; }
        public Status Status { get; set; }
        public DateTime Date { get; set; }
    }
}