using System.Timers;
using System.Xml;

namespace LaLiga
{
    internal class Program
    {
        public Program() { }
        private static string pathstring = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..") + "\\LaLiga.xml");

        public static void Main(string[] args)
        {


            if (File.Exists(pathstring))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(pathstring);
                Console.WriteLine("open");

            }
            else
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml("<liga></liga>");
                xmlDoc.Save(pathstring);
                Console.WriteLine("noopen");
            }
            
        }
    }
}