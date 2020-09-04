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
    public partial class _14_View_Charts : Form
    {
        public _14_View_Charts(string username)
        {
            InitializeComponent();
            label4.Text = username;
        }

        List<string> suspect = new List<string>();

        void chart()
        {
            XmlDocument doc = new XmlDocument();
            string case_id = comboBox1.SelectedItem.ToString();
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
                            if (!suspect.Contains(item))
                            {
                                suspect.Add(item);
                            }

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
                            this.chart1.Series["Points"].Points.AddXY(namevalue, pointsvalue);
                        }
                    }
                }
            }
            catch (Exception)
            {

            }

        }

        private void _14_View_Charts_Load(object sender, EventArgs e)
        {
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

                    string status = children[2].Name;
                    string ssvalue = children[2].InnerText;


                    if (!comboBox1.Items.Contains(idvalue))
                    {
                        comboBox1.Items.Add(idvalue);
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            chart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _8_Officer_Functions f = new _8_Officer_Functions(label4.Text);
            this.Hide();
            f.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _10_officer_view_suspects f = new _10_officer_view_suspects(label4.Text);
            this.Hide();
            f.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _12_officer_view_cases f = new _12_officer_view_cases(label4.Text);
            this.Show();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _9_officer_add_result f = new _9_officer_add_result(label4.Text);
            this.Hide();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _8_Officer_Functions f = new _8_Officer_Functions(label4.Text);
            this.Hide();
            f.Show();
        }
    }
}
