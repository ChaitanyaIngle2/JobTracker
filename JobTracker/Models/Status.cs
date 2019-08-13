using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JobTracker.Models
{
    public class Status
    {
        // -------------------------------------------------
        // Class Variables

        public int Id { get; set; }
        public string StatusName { get; set; }

    }
}