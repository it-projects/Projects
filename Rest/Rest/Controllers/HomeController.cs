using Rest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XML_Reader;

namespace Rest.Controllers
{
    public class HomeController : Controller
    {

        Document doc = new Document();
        ReadClass read = new ReadClass();

        Collection<string> pom;

        private Document Doc_read()
        {
            pom = read.Text_reader();

            doc.HeadTitle = pom[0];
            doc.Title = pom[1];
            doc.Text = pom[2];
            doc.Name = pom[3];
            doc.Adress = pom[4];
            doc.City = pom[5];
            doc.PostCode = pom[6];
            doc.Company = pom[7];
            doc.Phone = pom[8];
            doc.Email = pom[9];
            doc.Ico = pom[10];

            return doc;
        }


        // GET: Home
        public ActionResult Index()
        {
            return View(Doc_read());
        }

        public ActionResult Galery()
        {
            return View(Doc_read());
        }

        public ActionResult Contact()
        {
            return View(Doc_read());
        }
    }
}