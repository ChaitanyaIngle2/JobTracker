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
        // Array to store possible Status names
        private string[] statuses = new string[6];

        private int statusId;
        private string statusName;

        // -------------------------------------------------
        // Class Variables with Accessors
        public int StatusId
        {
            get { return statusId; }
            set
            {
                if (value < 0 || value > 5) {
                    statusId = 0;
                }
                else {
                    statusId = value;
                }
            }
        }

        public string StatusName
        {
            get { return statusName; }
            set
            {
                if (statuses.Contains(value))
                {
                    statusName = value;
                }
                else
                {
                    statusName = statuses[0];
                }
            }
        }

        // -------------------------------------------------
        // Constructors
        public Status(int id)
        {
            if (id < 0 || id > 5)
            {
                id = 0;
            }
            statusId = id;

            statuses[0] = "Not Submitted";
            statuses[1] = "Applied";
            statuses[2] = "Phone Interview";
            statuses[3] = "On-Site Interview";
            statuses[4] = "Rejected";
            statuses[5] = "Hired";

            statusName = statuses[statusId];
        }
    }
}