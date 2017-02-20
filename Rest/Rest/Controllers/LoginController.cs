using Rest.Models;
using System.Collections.ObjectModel;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;


namespace Rest.Controllers
{
    public class LoginController : Controller
    {

        Document doc = new Document();
        [HttpPost]
        public ActionResult Log_in(Document document)
        {
            if(doc.LoginName == document.LoginName && doc.LoginPassword == document.LoginPassword)
            {
                doc.predicate = true;
                return View("Form", doc);
            }

            return View("_Login");
            
        }
      
        [HttpPost]
        public ActionResult Log_Out()
        {
            
            return View("_Login");
        }

        [HttpPost]
        public ActionResult JL_Pdf(HttpPostedFileBase Jl)
        {
            string JL = "JL.pdf";
            
            if(Jl==null)
            {
                doc.predicate = true;
                return View("Form", doc);
            }

            if (Jl.FileName == JL)
            {
                Jl.SaveAs(Server.MapPath("~/Files/") + Jl.FileName);
            }
            
            return View("_Login");
        }

        [HttpPost]
        public ActionResult Menu_Pdf(HttpPostedFileBase Menu)
        {
            string menu = "Menu.pdf";

            if (Menu == null)
            {
                doc.predicate = true;
                return View("Form", doc);
            }
            if (Menu.FileName == menu)
            {
                Menu.SaveAs(Server.MapPath("~/Files/") + Menu.FileName);
            }
           
            return View("_Login");
        }

        [HttpPost]
        public ActionResult Akce_Pdf(HttpPostedFileBase Akce)
        {
            string akce = "Akce.pdf";

            if (Akce == null)
            {
                doc.predicate = true;
                return View("Form", doc);
            }
            if (Akce.FileName == akce)
            {
                Akce.SaveAs(Server.MapPath("~/Files/") + Akce.FileName);
            }
            
            return View("_Login");
        }

        // GET: Login
        public ActionResult _Login()
        {
            
            return View();
        }

        public ActionResult Form()
        {
            doc.predicate = false;
            return View(doc);
        }
    }
}