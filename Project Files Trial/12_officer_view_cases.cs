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
    public partial class _12_officer_view_cases : Form
    {
        public _12_officer_view_cases(string username)
        {
            InitializeComponent();
            label3.Text = username;
            get_OfficerID();
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

                    string type = children[1].Name;
                    string typevalue = children[1].InnerText;

                    string statuss = children[2].Name;
                    string statusvalue = children[2].InnerText;

                    string description = children[4].Name;
                    string descriptionvalue = children[4].InnerText;

                    string officer_ID = children[5].Name;
                    string off_IDvalue = children[5].InnerText;

                    string criminal = children[9].Name;
                    string criminalvalue = children[9].InnerText;

                    if (off_IDvalue == label4.Text)
                    {
                        crime_data.Rows.Add(new string[] { idvalue, typevalue, statusvalue, descriptionvalue, criminalvalue });

                    }
                }
            }

            catch (Exception)
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void _12_officer_view_cases_Load(object sender, EventArgs e)
        {
        }
        public void get_OfficerID()
        {
            XmlDocument doc = new XmlDocument();

            try
            {
                doc.Load("Officers.xml");
                XmlNodeList list = doc.GetElementsByTagName("Officer");

                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList childrens = list[i].ChildNodes;

                    string id = childrens[0].Name;
                    string idvalue = childrens[0].InnerText;

                    string username = childrens[3].Name;
                    string usernamevalue = childrens[3].InnerText;

                    if (label3.Text == usernamevalue)
                    {
                        label4.Text = idvalue;
                        //break;
                    }

                }
            }
            catch (Exception)
            {
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _8_Officer_Functions f = new _8_Officer_Functions(label3.Text);
            this.Hide();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _9_officer_add_result f = new _9_officer_add_result(label3.Text);
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _10_officer_view_suspects f = new _10_officer_view_suspects(label3.Text);
            this.Hide();
            f.Show();
        }

        private void crime_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
