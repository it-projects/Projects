using Rest.Models;
using System.Collections.ObjectModel;
using System.IO;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using XML_Reader;

namespace Rest.Controllers
{
    public class LoginController : Controller
    {

        Document doc = new Document();
        ReadClass reader = new ReadClass();

        private void Login()
        {
            Collection<string> pom = reader.Login_reader();

            doc.LoginName = pom[0];
            doc.LoginPassword = pom[1];
            doc.LoginEmail = pom[2];
        }

        private void Document()
        {
            Collection<string> pom = reader.Login_reader();

            pom = reader.Text_reader();

            doc.Name = pom[3];
            doc.Adress = pom[4];
            doc.City = pom[5];
            doc.PostCode = pom[6];
            doc.Company = pom[7];
            doc.Phone = pom[8];
            doc.Email = pom[9];
            doc.Ico = pom[10];
        }

        [HttpPost]
        public ActionResult Log_in(Document document)
        {
            Login();
            Document();

            if (doc.LoginName == document.LoginName && doc.LoginPassword == document.LoginPassword)
            {
                doc.predicate = true;
                return View("Form", doc);
            }

            doc.predicate = false;
            return View("_Login", doc);
        }

        [HttpPost]
        public ActionResult Log_Out()
        {
            Document();
            return View("_Login", doc);
        }

        [HttpPost]
        public ActionResult JL_Pdf(HttpPostedFileBase Jl)
        {
            string JL = "JL.pdf";

            if (Jl.FileName == JL)
            {
                Jl.SaveAs(Server.MapPath("~/Files/") + Jl.FileName);
            }
            Document();
            return View("_Login", doc);
        }

        [HttpPost]
        public ActionResult Menu_Pdf(HttpPostedFileBase Menu)
        {
            string menu = "Menu.pdf";

            if (Menu.FileName == menu)
            {
                Menu.SaveAs(Server.MapPath("~/Files/") + Menu.FileName);
            }
            Document();
            return View("_Login", doc);
        }

        [HttpPost]
        public ActionResult Akce_Pdf(HttpPostedFileBase Akce)
        {
            string akce = "Akce.pdf";

            if (Akce.FileName == akce)
            {
                Akce.SaveAs(Server.MapPath("~/Files/") + Akce.FileName);
            }
            Document();
            return View("_Login", doc);
        }

        // GET: Login
        public ActionResult _Login()
        {
            Document();
            return View(doc);
        }

        public ActionResult Form()
        {
            Document();
            return View(doc);
        }
    }
}