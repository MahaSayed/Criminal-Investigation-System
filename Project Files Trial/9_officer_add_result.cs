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
    public partial class _9_officer_add_result : Form
    {
        List<string> p = new List<string>();
        int max = 0;
        public _9_officer_add_result(string sent_username)
        {
            InitializeComponent();
            label6.Text = sent_username;

            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load("Suspects.xml");
                XmlNodeList list = doc.GetElementsByTagName("Person");
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList children = list[i].ChildNodes;
                    string points = children[5].Name;
                    string pointsvalue = children[5].InnerText;
                    p.Add(pointsvalue);
                }
            }
            catch (Exception)
            {

            }
            
            String TheImageFile;
            for (int i = 0; i < p.Count; i++)
            {
                if (int.Parse(p[i]) > max)
                {
                    max = int.Parse(p[i]);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string check = comboBox1.SelectedItem.ToString();
            string criminal = comboBox2.SelectedItem.ToString();
            Crime c = new Crime();
            Officer of = new Officer();
            of.officer_username = label6.Text;
            c.add_criminal(comboBox2.SelectedItem.ToString(), of);

            string Status = c.status.ToString();
            try
            {
                XmlDocument XMLEdit = new XmlDocument();
                XMLEdit.Load("CRIMEDATA.xml");

                XmlElement XMLEditNode = XMLEdit.DocumentElement;

                foreach (XmlNode node in XMLEditNode) // Loop through XML file
                {
                    if (node["CrimeID"].InnerText == check) // Check for the ID field information
                    {
                        node["Status"].InnerText = "1";
                        node["Criminal"].InnerText = criminal;
                        break;
                    }
                }
               // MessageBox.Show("YARAAAB");
                XMLEdit.Save("CRIMEDATA.xml");
            }
            catch (Exception)
            {

            }
        }

        private void _9_officer_add_result_Load(object sender, EventArgs e)
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

                    if (ssvalue == "0")
                    {
                        if (!comboBox1.Items.Contains(idvalue))
                        {
                            comboBox1.Items.Add(idvalue);
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load("CRIMEDATA.xml");
                XmlNodeList list = doc.GetElementsByTagName("crime");
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList children = list[i].ChildNodes;
                    ///// 3yzeen n3rf type di anhy column
                    string id = children[0].Name;
                    string idvalue = children[0].InnerText;

                    string Name = children[7].Name;
                    string namevalue = children[7].InnerText;
                    if (idvalue == comboBox1.SelectedItem.ToString())
                    {
                        string[] temp = namevalue.Split(new string[] { "," }, StringSplitOptions.None);
                        foreach (string item in temp)
                        {
                            if (!comboBox2.Items.Contains(item))////////
                            {
                                comboBox2.Items.Add(item);
                            }
                        }
                    }
                }
            }

            catch (Exception)
            {

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
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

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void officer_back_btn_Click(object sender, EventArgs e)
        {
            _8_Officer_Functions f = new _8_Officer_Functions(label6.Text);
            this.Hide();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string case_id = comboBox1.SelectedItem.ToString();
            _13_Predict_Result predict = new _13_Predict_Result(case_id, label6.Text);
            this.Hide();
            predict.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _8_Officer_Functions f = new _8_Officer_Functions(label6.Text);
            this.Hide();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            _14_View_Charts f = new _14_View_Charts(label6.Text);
            this.Hide();
            f.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
