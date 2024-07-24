using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;

namespace laliga
{
    internal class MainProject
    {
        private static string pathstring = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..", "israel.xml"));
        
        public static void Main1(string[] args)
        {
            XmlDocument xmlDoc = LoadOrCreateXmlDocument();

            XmlElement team = xmlDoc.CreateElement("team");

            List<string> elementNames = new List<string>() { "name", "rank", "goal" };
            List<string> elementValues = new List<string>() { "atletico madrid", "1", "65" };

            if (elementNames.Count == elementValues.Count)
            {
                for (int i = 0; i < elementNames.Count; i++)
                {
                    XmlElement child = xmlDoc.CreateElement(elementNames[i]);
                    child.InnerText = elementValues[i];
                    team.AppendChild(child);
                }
            }
            else
            {
                Console.WriteLine("Error: Element names count does not match element values count.");
            }
            XmlNodeList? names = xmlDoc.SelectNodes("liga/team/winer");
            

            if (names != null)
            {
                foreach (XmlNode child1 in names)
                {
                    XmlElement new_chikd = xmlDoc.CreateElement("winer");
                    child1.InnerText = "sdfg";

                }
            }
            

            XmlNode root = xmlDoc.DocumentElement;
            root?.AppendChild(team);

            Save(xmlDoc);

            Console.WriteLine("Elements added successfully to israel.xml.");
        }

        public static void Save(XmlDocument xml)
        {
            xml.Save(pathstring);
        }

        private static XmlDocument LoadOrCreateXmlDocument()
        {
            XmlDocument xmlDoc = new XmlDocument();

            try
            {
                if (File.Exists(pathstring))
                {
                    xmlDoc.Load(pathstring);
                }
                else
                {
                    xmlDoc.LoadXml("<liga></liga>");
                    xmlDoc.Save(pathstring);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading or saving XML document: " + ex.Message);
            }

            return xmlDoc;
        }
    }
}
