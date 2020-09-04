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
    public partial class _2_Admin_LOGIN : Form
    {
        

        public _2_Admin_LOGIN()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void admin_back_btn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void admin_login_btn_Click(object sender, EventArgs e)
        {           
            XmlDocument doc = new XmlDocument();
            if (admin_username_textBox.Text == "admin" && admin_password_textBox.Text == "admin")
            {
                _4_Admin_functions f = new _4_Admin_functions();
                this.Hide();
                f.Show();
               // break;
            }
            else
            {
                try
                {
                    doc.Load("Admins.xml");
                    XmlNodeList list = doc.GetElementsByTagName("Admin");
                    for (int i = 0; i < list.Count; i++)
                    {
                        XmlNodeList children = list[i].ChildNodes;
                        string username = children[0].Name;
                        string uservalue = children[0].InnerText;

                        string password = children[1].Name;
                        string passvalue = children[1].InnerText;
                        if (uservalue == admin_username_textBox.Text && passvalue == admin_password_textBox.Text)
                        {
                            _4_Admin_functions f = new _4_Admin_functions();
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
}
