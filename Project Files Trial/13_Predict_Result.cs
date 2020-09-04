using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Project_Files_Trial
{
    public partial class _13_Predict_Result : Form
    {

        List<string> suspect = new List<string>();
        List<int> points_list = new List<int>();
        public _13_Predict_Result(string case_id, string username)
        {
            InitializeComponent();
            // MessageBox.Show(case_id);
            label8.Text = username;
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load("CRIMEDATA.xml");
                XmlNodeList list = doc.GetElementsByTagName("crime");
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList children = list[i].ChildNodes;

                    string id = children[0].Name;
                    string idvalue = children[0].InnerText;

                    string Name = children[7].Name;
                    string namevalue = children[7].InnerText;
                    if (idvalue == case_id)
                    {
                        string[] temp = namevalue.Split(new string[] { "," }, StringSplitOptions.None);
                        foreach (string item in temp)
                        {
                            suspect.Add(item);

                        }
                    }
                }
            }

            catch (Exception)
            {

            }

            XmlDocument doc1 = new XmlDocument();
            try
            {
                doc1.Load("Suspects.xml");
                XmlNodeList list = doc1.GetElementsByTagName("Person");

                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList children = list[i].ChildNodes;
                    string id = children[0].Name;
                    string idvalue = children[0].InnerText;

                    string Name = children[1].Name;
                    string namevalue = children[1].InnerText;

                    string pointss = children[5].Name;
                    string pointsvalue = children[5].InnerText;

                    foreach (string sus in suspect)
                    {
                        if (sus == namevalue)
                        {
                            points_list.Add(int.Parse(pointsvalue));
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void _13_Predict_Result_Load(object sender, EventArgs e)
        {
            int maxi = 0;
            foreach (int point in points_list)
            {
                if (point > maxi)
                {
                    maxi = point;
                }
            }
            get_suspect(maxi);

        }

        void get_suspect(int maxi)
        {
            XmlDocument doc = new XmlDocument();
            String TheImageFile;
            try
            {
                doc.Load("Suspects.xml");
                XmlNodeList list = doc.GetElementsByTagName("Person");
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList children = list[i].ChildNodes;
                    string id = children[0].Name;
                    string idvalue = children[0].InnerText;

                    string Name = children[1].Name;
                    string namevalue = children[1].InnerText;

                    string age = children[2].Name;
                    string agevalue = children[2].InnerText;

                    string location = children[3].Name;
                    string locationvalue = children[3].InnerText;

                    string image = children[4].Name;
                    string image_Text = children[4].InnerText;

                    string pointss = children[5].Name;
                    string pointsvalue = children[5].InnerText;

                    if (int.Parse(pointsvalue) == maxi)
                    {
                        criminal_ID_textBox.Text = idvalue;
                        criminal_Name_textBox.Text = namevalue;
                        criminal_age_textBox.Text = agevalue;
                        criminal_location_textBox.Text = locationvalue;
                        TheImageFile = image_Text;
                        Image TheImage = Image.FromFile(TheImageFile);
                        pictureBox1.Image = TheImage;
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void officer_back_btn_Click(object sender, EventArgs e)
        {
            _9_officer_add_result f = new _9_officer_add_result(label8.Text);
            this.Hide();
            f.Show();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Officer_Page_Case_Panel_btn_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            _12_officer_view_cases f = new _12_officer_view_cases(label6.Text);
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            _10_officer_view_suspects f = new _10_officer_view_suspects(label6.Text);
            this.Hide();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _14_View_Charts f = new _14_View_Charts(label6.Text);
            this.Hide();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }
    }
}
