using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using laliga;

namespace Test4
{
    internal class Manager_of_rabay
    {
        private XmlDocument xmldoc;
        public Manager_of_rabay(XmlDocument doc)
        {
            xmldoc = doc;
        }
        private XmlNode Getroot()
        {
            return xmldoc.GetElementsByTagName("queries")[0];

        }

        public string addquery(List<string> new_qurey)
        {

            List<string> list = new_qurey;
            string query = Changequry(new_qurey);

            XmlElement tytel = xmldoc.CreateElement("query");
            List<string> tagsname = new List<string>() { "day", "DadyMonth", "Month", "Year" };
            for (int i = 0; i < tagsname.Count; i++)
            {
                XmlElement child = xmldoc.CreateElement(tagsname[i]);
                child.InnerText = new_qurey[i];
               tytel.AppendChild(child);
            }
            XmlElement child1 = xmldoc.CreateElement("result");
            child1.InnerText = query;
            tytel.AppendChild(child1);

            Getroot().AppendChild(tytel);
            save();
            return query;
        }
        public static string Changequry(List<string> new_qurey)
        {
            if (new_qurey!= null)
            {
                string Day = "";
                string daynonth = "";
               
                string year = "";
                switch (new_qurey[0])
                {
                    case "ראשון":
                        Day = "באחד";
                        break;
                    case "שני":
                        Day = "בשני";
                        break;
                    case "שלישי":
                        Day = "בשלישי";
                        break;
                    case "רביעי":
                        Day = "ברביעי";
                        break;

                    case "חמישי":
                        Day = "בחמישי";
                        break;
                    case "שישי":
                        Day = "בשישי";
                        break;

                    default:
                        // code block
                        break;
                }
                switch (new_qurey[1])
                {
                    case "1":
                        daynonth = "יום אחד";
                        break;
                    case "2":
                        daynonth = "שני ימים";
                        break;
                    case "3":
                        daynonth = "שלשה ימים";
                        break;
                    case "4":
                        daynonth = "ארבעה ימים";
                        break;

                    case "5":
                        daynonth = "חמשה ימים";
                        break;
                    case "6":
                        daynonth = "ששה ימים";
                        break;

                    case "7":
                        daynonth = "שבעה ימים";
                        break;
                    case "8":
                        daynonth = "שמונה ימים";
                        break;
                    case "9":
                        daynonth = "תשעה ימים";
                        break;
                    case "10":
                        daynonth = "עשרה ימים";
                        break;

                    case "11":
                        daynonth = "אחד עשר ימים";
                        break;
                    case "12":
                        daynonth = "שנים עשר ימים";
                        break;

                    case "13":
                        daynonth = " שלשה עשר יימים";
                        break;
                    case "14":
                        daynonth = "ארבעה עשר ימים";
                        break;
                    case "15":
                        daynonth = " חמשה עשר ימים ";
                        break;
                    case "16":
                        daynonth = " ששה עשר ימים";
                        break;

                    case "17":
                        daynonth = "שבעה עשר ימים";
                        break;
                    case "18":
                        daynonth = "שמונה עשר ימים";
                        break;

                    case "19":
                        daynonth = "תשעה עשר ימים";
                        break;
                    case "20":
                        daynonth = "  עשרים ימים  ";
                        break;
                    case "21":
                        daynonth = "  עשרים ואחת ימים ";
                        break;
                    case "22":
                        daynonth = " עשרים ושתיים ימים ";
                        break;

                    case "23":
                        daynonth = " עשרים ושלוש ימים ";
                        break;
                    case "24":
                        daynonth = " עשרים וארבע ימים ";
                        break;
                    case "25":
                        daynonth = " עשרים וחמש ימים ";
                        break;
                    case "26":
                        daynonth = " עשרים ושש ימים ";
                        break;

                    case "27":
                        daynonth = " עשרים ושבע ימים ";
                        break;
                    case "28":
                        daynonth = " עשרים ושמונה ימים ";
                        break;
                    case "29":
                        daynonth = " עשרים ותשע ימים ";
                        break;
                    case "30":
                        daynonth = " שלושים ימים ";
                        break;

                    default:
                        // code block
                        break;
                }
                switch (new_qurey[3])
                {
                    case "תשפד":
                        year = " ארבע   ";
                        break;
                    case "תשפה":
                        year = "  חמש  ";
                        break;
                    case "תשפו":
                        year = "  שש  ";
                        break;
                    case "תשפז":
                        year = " שבע ";
                        break;

                    case "תשפח":
                        year = "   שמונה  ";
                        break;
                    case "תשפט":
                        year = "  תשע ";
                        break;
                    default:
                        // code block
                        break;

                       



                }

                return $" {Day} בשבת {daynonth}  לירח {new_qurey[2]} שנת חמשת אלפים ושבע מאות ושמונים ו {year}לבריאת העולם";
            }
            return null ;
        }

        public void save()
        {
            MainProject.Save(xmldoc);

        }


    }
}
