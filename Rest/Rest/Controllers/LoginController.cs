using Rest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rest.Controllers
{
    public class LoginController : Controller
    {
        Login login = new Login();
        HomeController home = new HomeController();

        
        private Collection<string> Login_Read()
        {
            home.pom = home.read.Login_reader();

            return home.pom;
        }

        // GET: Login
        public ActionResult _Login()
        {
            return View(home.Doc_read());
        }

        public ActionResult Form()
        {
            return View(home.Doc_read());
        }
    }
}