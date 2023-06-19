using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XpressLoan.Classes
{
    internal class ScheduleDetails
    {
        public string repID { get; set; } = "";

        public string repDate { get; set; } = "";

        public string amount { get; set; } = "";
        public string status { get; set; } = "";
        public string paidDate { get; set; } = "";
        public ScheduleDetails(string repID, string repDate, string amount, string status, string paidDate)
        {
            this.repID = repID;
            this.repDate = repDate;
            this.amount = amount;
            this.status = status;
            this.paidDate = paidDate;
        }
        
    }
}
