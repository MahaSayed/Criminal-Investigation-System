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
using System.IO;

namespace Project_Files_Trial
{
    public partial class _10_officer_view_suspects : Form
    {
        public _10_officer_view_suspects(string username)
        {
            InitializeComponent();
            label4.Text = username;            
        }
        List<string> suspect = new List<string>();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            suspects.Rows.Clear();
            suspects.Refresh();
            suspects.Visible = true;
            int selected_row = Show_Suspects.CurrentCell.RowIndex;
            DataGridViewRow newDataRow = Show_Suspects.Rows[selected_row];
            string Suspect_Name = newDataRow.Cells[0].Value.ToString();

            XmlDocument doc = new XmlDocument();
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
                    if (namevalue == Suspect_Name)
                    {
                        suspects.Rows.Add(new string[] { idvalue, namevalue, agevalue, locationvalue, image_Text });
                        break;
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show_Suspects.Rows.Clear();
            Show_Suspects.Refresh();
            

            XmlDocument doc = new XmlDocument();

            try
            {
                doc.Load("CRIMEDATA.xml");
                XmlNodeList list = doc.GetElementsByTagName("crime");
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList children = list[i].ChildNodes;
                    ///// 3yzeen n3rf type di anhy column
                    string id = children[1].Name;
                    string idvalue = children[1].InnerText;

                    string Name = children[7].Name;
                    string namevalue = children[7].InnerText;
                    if (idvalue == comboBox1.SelectedItem.ToString())
                    {
                        string[] temp = namevalue.Split(new string[] { "," }, StringSplitOptions.None);
                        foreach (string item in temp)
                        {
                            //////// Solve mawdoo3 el duplicates ////////
                            if(!suspect.Contains(item))
                            {
                                suspect.Add(item);
                            }
                           // Show_Suspects.Rows.Add(new string[] { item });
                        }
                    }
                }
                foreach (string item in suspect)
                {
                    Show_Suspects.Rows.Add(new string[] { item });
                }

            }

            catch (Exception)
            {

            }

        }

        private void _10_officer_view_suspects_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            
            try
            {
                doc.Load("CRIMEDATA.xml");
                XmlNodeList list = doc.GetElementsByTagName("crime");

                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList childrens = list[i].ChildNodes;

                    string id = childrens[1].Name;
                    string ivalue = childrens[1].InnerText;
                    if (comboBox1.Items.Contains(ivalue) == false)
                    {
                        comboBox1.Items.Add(ivalue);
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
            _8_Officer_Functions f = new _8_Officer_Functions(label4.Text);
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
            _9_officer_add_result f = new _9_officer_add_result(label4.Text);
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _12_officer_view_cases f = new _12_officer_view_cases(label4.Text);
            this.Hide();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Slideshow f = new Slideshow(label4.Text);
            this.Hide();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _14_View_Charts f = new _14_View_Charts(label4.Text);
            this.Hide();
            f.Show();
        }
    }
}
