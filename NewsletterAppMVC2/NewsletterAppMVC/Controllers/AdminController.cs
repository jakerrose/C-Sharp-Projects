
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities()) 
                {
                    var signups = db.SignUp1;
                    var signUpVms = new List<SignUpVm>();
                    foreach (var signup in signups) 
                    {
                        var signupVm = new SignUpVm();
                        signupVm.FirstName = signup.FirstName;
                        signupVm.LastName = signup.LastName;
                        signupVm.EmailAddress = signup.EmailAddress;
                        signUpVms.Add(signupVm);
                    }

                return View(signUpVms);
                }
        }
    }
}