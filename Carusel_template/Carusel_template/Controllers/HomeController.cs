using Carusel_template.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XML_Reader;

namespace Carusel_template.Controllers
{
    public class HomeController : Controller
    {
        ReadClass read = new ReadClass();
        Document doc = new Document();

        private Document Doc()
        {
            Collection<string> pom = read.Text_reader();

            doc.Title1 = pom[0];
            doc.Title2 = pom[1];
            doc.Title3 = pom[2];
            doc.Title4 = pom[3];

            doc.Text1 = pom[4];
            doc.Text2 = pom[5];
            doc.Text3 = pom[6];
            doc.Text4 = pom[7];

            doc.Email = pom[8];
            doc.Phone = pom[9];
            doc.Address = pom[10];
            doc.City = pom[11];
            doc.PostCode = pom[12];
            doc.ItFirma = pom[13];

            return doc;
        }



        // GET: Home
        public ActionResult Index()
        {
            return View(Doc());
        }

        public ActionResult Gallery()
        {
            return View(Doc());
        }

        public ActionResult Contact()
        {
            return View(Doc());
        }
    }
}