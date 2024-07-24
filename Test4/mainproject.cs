using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using Test4;

namespace laliga
{
    internal class MainProject
    {
        
        private static string pathstring = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..", "queries.xml"));

        public static XmlDocument MainP()
        {
            XmlDocument xmlDoc = LoadOrCreateXmlDocument();

            XmlNode root = xmlDoc.DocumentElement;
            //root?.AppendChild();
            return xmlDoc;

            Save(xmlDoc);

            Console.WriteLine("Elements added successfully to qureies.xml.");
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
                    return xmlDoc;
                }
                else
                {
                    xmlDoc.LoadXml("<queries></queries>");
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

