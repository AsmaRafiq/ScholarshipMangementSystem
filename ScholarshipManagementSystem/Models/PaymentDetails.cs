using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ScholarshipManagementSystem.Models
{
    public class PaymentDetails
    {
        //after interview scholarship approved or rejected
        [DisplayName("Option 1")]
        public bool Approved { get; set; }

        [DisplayName("Option 2")]
        public bool Hold { get; set; }
        [DisplayName("Option 3")]
        public bool Reject { get; set; }

        public float ScholarshipAmount { get; set; }
        public float PastPayedAmount { get; set; }
        //check given from office or not
        [DisplayName("Option 1")]
        public bool CheckGiven { get; set; }

        [DisplayName("Option 2")]
        public bool OnHold { get; set; }
        // check recieved from school/college/university or not
        [DisplayName("Option 1")]
        public bool CheckRecieved { get; set; }

        [DisplayName("Option 2")]
        public bool CheckDenied { get; set; }

    }
}