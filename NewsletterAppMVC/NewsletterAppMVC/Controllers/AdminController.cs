using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewsletterAppMVC.ViewModels;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities()) 
                {
                //var signups = db.SignUp1.Where(x => x.Removed == null).ToList();
                var signups = (from c in db.SignUp1
                               where c.Removed == null
                               select c).ToList();
                var signUpVms = new List<SignUpVm>();
                foreach (SignUp1 signup in signups) 
                    {
                    var signupVm = new SignUpVm();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signUpVms.Add(signupVm);
                }

                return View(signUpVms);
            }
        }
        public ActionResult Unsubscribe (int Id)
        {
            using (NewsletterEntities db = new NewsletterEntities()) {
                var signup = db.SignUp1.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}