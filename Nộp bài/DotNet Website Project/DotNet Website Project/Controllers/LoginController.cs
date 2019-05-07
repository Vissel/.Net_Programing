
using DotNet_Website_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNet_Website_Project.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Autherize(USER model)
        {
            using (LoginEntity db = new LoginEntity())
            {
                var account = db.USERS.Where(x => x.USERNAME == model.USERNAME && x.PASSOWORD == model.PASSOWORD).FirstOrDefault();
                if(account == null)
                {
                    model.LoginErrorMessage = "Username hoặc Password không tồn tại. Thử lại !";
                    return View("Index", model);
                }
                else
                {
                    Session["userID"] = account.USER_ID;
                    return RedirectToAction("Index", "Home");
                }
            }
        }

        public ActionResult Logout()
        {
            int userId = (int) Session["userID"];
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}