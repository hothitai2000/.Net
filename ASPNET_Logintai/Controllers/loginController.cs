using ASPNET_Logintai.code;
using ASPNET_Logintai.Models;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET_Logintai.Controllers
{
    public class loginController : Controller
    {
        // GET: login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
            var result = new accountModel().Login(model.UserName,model.Password);

            if (result && ModelState.IsValid)
            {
                SessionHelper.SetSession(new UserSession()
                {
                    UserName =model.UserName
                });

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không đúng");
            }
            return View(model);
        }
    }
}

