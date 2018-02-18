using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab_3._1.Controllers
{
    public class MasterController : Controller
    {
        //Name
        [HttpGet]
        public ActionResult Name()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Name")]
        public ActionResult NamePost(string name)
        {
       
            return View("Name",model:name);
        }

        //Email
        [HttpGet]
        public ActionResult Email()
        {

            return View();
        }



        //Email
        [HttpPost]
        public ActionResult Email(string email)
        {
            if (email == "")
            {
                ViewBag.Email = "Can not empty";
            }
            //else
            //{
            //    ViewBag.Email = email;
            //}
            else if(email != "")
                {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    ViewBag.Email = addr;
                }
                catch
                {
                    ViewBag.Email = "Not a proper email";
                }
            }
            
            
            return View();
        }



        //DOB

        [HttpGet]
        public ActionResult DOB()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DOB(DateTime date)
        {
            string strDate = date.ToString();
            try
            {
                DateTime dt = DateTime.Parse(strDate);
                if ((dt.Month != System.DateTime.Now.Month) || (dt.Day < 1 && dt.Day > 31) || dt.Year != System.DateTime.Now.Year)
                {
                    ViewBag.Date = dt;
                }
                else
                {
                    
                    ViewBag.Date = "Prob";
                }
            }
            catch
            {
                
            }
            
            return View();
        }

        
        [HttpGet]
        public ActionResult BG()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BG(string bloodGroup)
        {
            if(bloodGroup=="")
            {
                ViewBag.BloodGroup = "Can't be null";
            }
            else
            {
                ViewBag.BloodGroup = bloodGroup;
            }
            
            return View();
        }


    }
}