using laliga;
using System.Xml;

namespace Test4
{
    public partial class Form1 : Form
    {
        private Manager_of_rabay rabaymanager;
        public Form1()
        {
            InitializeComponent();
            XmlDocument rabaydoc = MainProject.MainP();
            rabaymanager = new Manager_of_rabay(rabaydoc);
        }

     

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> date = new List<string>()
            {
            cmbday.Text,
            cmbmunth.Text,
            cmbmunth2.Text,
            cmbyear.Text,
            };
            if (cmbday.Text != "" && cmbmunth.Text != "" && cmbmunth2.Text != "" && cmbyear.Text != "")
            {
                string result = rabaymanager.addquery(date);
                MessageBox.Show(result);
            }
            else 
            {
                MessageBox.Show("אנא תבדוק שכל השדות מלאות");
            
            }


        }
    }
}
