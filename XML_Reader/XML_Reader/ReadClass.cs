using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;

namespace XML_Reader
{
    public class ReadClass
    {
        private const string path = "";

        private const string loginName_file = "XML_Login.xml";
        private const string textName_file = "XML_Text.xml";

        private readonly XmlDocument doc = new XmlDocument();

        public ICollection<string> Login_reader()
        {
            doc.Load(path + loginName_file);
            ICollection<string> helper = new Collection<string>();

            foreach(var n in doc.SelectNodes("/user"))
            {
                foreach(XmlNode m in (IEnumerable)n)
                {
                    helper.Add(m.InnerText);
                }
            }

            return helper;
        }

        public ICollection<string> Text_reader()
        {
            doc.Load(path + loginName_file);
            ICollection<string> helper = new Collection<string>();

            foreach (var n in doc.SelectNodes("/document/customer"))      // jméno, adresa , psč
            {                                                             // ičo,dič, 
                foreach (XmlNode m in (IEnumerable)n)                     // telefon, email
                {                                                         // 0-6
                    helper.Add(m.InnerText);
                }
            }


            foreach (var n in doc.SelectNodes("/document/body-text"))
            {
                foreach (XmlNode m in (IEnumerable)n)
                {
                    helper.Add(m.InnerText);
                }
            }

            return helper;
        }
    }
}
