// See https://aka.ms/new-console-template for more information
using System.Xml;

namespace laliga
{
    public class Program
    {
        public static void Main()
        {
            string _pathstring = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..") + "\\drinks.xml");

            if (File.Exists(_pathstring))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(_pathstring);


            }


        }
}   }

















    
    































