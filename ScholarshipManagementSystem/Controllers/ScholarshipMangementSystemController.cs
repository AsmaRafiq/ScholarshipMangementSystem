using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ScholarshipManagementSystem.Models;

namespace ScholarshipManagementSystem.Controllers
{
    public class ScholarshipMangementSystemController : ApiController
    {
        [HttpGet]
        [Route("Api/ScholarshipMangementSystem/ChildDetails")]
        public bool ChildDetails(InterviewOfChild Interviews)
        {
            return true;
        }


        [HttpGet]
        [Route("Api/ScholarshipMangementSystem/AcademicStatus")]
        public bool AcademicStatus(InterviewOfChild Interviews)
        {
            return true;
        }


        [HttpGet]
        [Route("Api/ScholarshipMangementSystem/FamilyDetails")]
        public bool FamilyDetails(InterviewOfChild Interviews)
        {
            return true;
        }


        [HttpGet]
        [Route("Api/ScholarshipMangementSystem/InterviewDetails")]
        public bool InterviewDetails()
        {
            return true;
        }


        [HttpGet]
        [Route("Api/ScholarshipMangementSystem/ScholarshipDetails")]
        public float ScholarshipDetails()
        {
            return 0;
        }


        [HttpGet]
        [Route("Api/ScholarshipMangementSystem/PastPaymentHistory")]
        public float PastPaymentHistory()
        {
            return 0;
        }


        [HttpGet]
        [Route("Api/ScholarshipMangementSystem/PaymentCheck")]
        public bool PaymentCheck()
        {
            return true;
        }


        [HttpGet]
        [Route("Api/ScholarshipMangementSystem/PaymentRecieved")]
        public bool PaymentRecieved()
        {
            return true;
        }


    }
}
