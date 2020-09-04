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
    public partial class _3_Officer_LOGIN : Form
    {
        public _3_Officer_LOGIN()
        {
            InitializeComponent();
        }

        private void officer_back_btn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void officer_login_btn_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load("Officers.xml");
                XmlNodeList list = doc.GetElementsByTagName("Officer");
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList children = list[i].ChildNodes;

                    string id = children[0].Name;
                    string idvalue = children[0].InnerText;

                    string username = children[3].Name;
                    string uservalue = children[3].InnerText;

                    string password = children[4].Name;
                    string passvalue = children[4].InnerText;
                    if (uservalue == officer_username_textBox.Text && passvalue == officer_password_textBox.Text)
                    {
                        _8_Officer_Functions f = new _8_Officer_Functions(officer_username_textBox.Text);
                        this.Hide();
                        f.Show();
                        break;
                    }
                   
                }
            }
            catch (Exception)
            {

            }

            
        }
    }
}
