using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ScholarshipManagementSystem.Models
{
    public class InterviewOfChild
    {
        // personal and academic record of child
        public int Id { get; set; }
        public string Name { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public float PhoneNumber { get; set; }
        public int Class { get; set; }
        public string InstituteName { get; set; }
        public float PassingYear { get; set; }
        public string Grade { get; set; }
        // family status that house owned or rent
        [DisplayName("Option 1")] 
        public bool Option1 { get; set; }

        [DisplayName("Option 2")]
        public bool Option2 { get; set; }

    }
}