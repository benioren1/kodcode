using System;
using System.IO;
using System.Xml;

namespace israel
{
    internal class MainProject
    {
        private static string pathstring = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..", "israel.xml"));

        public static void Main(string[] args)
        {
            XmlDocument xmlDoc = LoadOrCreateXmlDocument();

            XmlElement country = xmlDoc.CreateElement("country");
            List<string> tagsname = new List<string>() { "city", "street" };
            foreach (string tagName in tagsname)
            {
                XmlElement child = xmlDoc.CreateElement(tagName);
                country.AppendChild(child);
            }

            xmlDoc.DocumentElement?.AppendChild(country); // Adding 'country' element to the root if it exists

            save(xmlDoc);

            Console.WriteLine("Elements added successfully to israel.xml.");
        }
        private static XmlDocument LoadOrCreateXmlDocument()
        {
            XmlDocument xmlDoc = new XmlDocument();

                if (File.Exists(pathstring))
                {
                    xmlDoc.Load(pathstring);
                }
                else
                {
                    xmlDoc.LoadXml("<israel></israel>");
                    xmlDoc.Save(pathstring);
                }
           

            return xmlDoc;
        }
        public static void save(XmlDocument xml)
        {

            xml.Save(pathstring);
        }

    }
}
