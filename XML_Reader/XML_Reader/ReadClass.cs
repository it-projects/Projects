using System.Collections;
using System.Collections.ObjectModel;
using System.IO;
using System.Xml;

namespace XML_Reader
{
    public class ReadClass
    {
        private const string path = "~/Models/";

        private const string loginName_file = "XML_Login.xml";
        private const string textName_file = "XML_Text.xml";

        private readonly XmlDocument doc = new XmlDocument();

        public Collection<string> Login_reader()
        {
            doc.Load(path + loginName_file);
            Collection<string> helper = new Collection<string>();

            foreach(var n in doc.SelectNodes("/users/user"))
            {
                foreach(XmlNode m in (IEnumerable)n)
                {
                    helper.Add(m.InnerText);
                }
            }

            return helper;
        }

        public Collection<string> Text_reader()
        {
            doc.Load(path + textName_file);
            Collection<string> helper = new Collection<string>();

            foreach (var n in doc.SelectNodes("/document/body-text"))        //4x title
            {                                                            
                foreach (XmlNode m in (IEnumerable)n)                   
                {                                                        
                    helper.Add(m.InnerText);
                }
            }

            foreach (var n in doc.SelectNodes("/document/customer"))       // 4x povídání
            {                                                              
                foreach (XmlNode m in (IEnumerable)n)                    
                {                                                         
                    helper.Add(m.InnerText);
                }
            }

            foreach (var n in doc.SelectNodes("/document/footer"))        // mail, telefon, adresa, it firma
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
