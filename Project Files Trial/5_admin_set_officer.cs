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
    public partial class _5_admin_set_officer : Form
    {
        int Officer_selected_row;
        List<Officer> olist = new List<Officer>();
        Dictionary<string, Officer> Dic_officer = new Dictionary<string, Officer>();
        DataTable dt = new DataTable();
        int counter = 1;
        List<string> ids = new List<string>();
        public _5_admin_set_officer()
        {
            InitializeComponent();
            XmlDocument doc = new XmlDocument();
            
            try
            {
                doc.Load("Officers.xml");
                XmlNodeList list = doc.GetElementsByTagName("Officer");

                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList childrens = list[i].ChildNodes;

                    string id = childrens[0].Name;
                    string ivalue = childrens[0].InnerText;
                    //ids.Add(ivalue);
                    //counter = list.Count;

                    string name = childrens[1].Name;
                    string nvalue = childrens[1].InnerText;

                    string no_crimes = childrens[2].Name;
                    string cvalue = childrens[2].InnerText;

                    string username = childrens[3].Name;
                    string uvalue = childrens[3].InnerText;

                    string password = childrens[4].Name;
                    string pvalue = childrens[4].InnerText;

                    if (officer_dataGridView1.ColumnCount == 0)
                    {
                        officer_dataGridView1.Columns.Add("ID", id);
                        officer_dataGridView1.Columns.Add("Name", name);
                        officer_dataGridView1.Columns.Add("No of Assigned Crimes", no_crimes);
                        officer_dataGridView1.Columns.Add("Username", username);
                        officer_dataGridView1.Columns.Add("Password", password);
                    }
                    officer_dataGridView1.Rows.Add(new string[] { ivalue, nvalue, cvalue, uvalue, pvalue });
                }
            }
            catch (Exception)
            {
            }
        }
        void clear()
        {
            officer_ID_textBox.Clear();
            Officer_Name_textBox.Clear();
            //no_crimes_textBox1.Clear();
            officer_usernmae_textBox.Clear();
            officer_password_textBox.Clear();
        }

        private void officer_add_Click(object sender, EventArgs e)
        {
            read_IDs();
            string ID = officer_ID_textBox.Text;
            string Name = Officer_Name_textBox.Text;
            string no_of_crimes = no_crimes_textBox1.Text;
            string Username = officer_usernmae_textBox.Text;
            string Password = officer_password_textBox.Text;

            Officer newoff = new Officer(Name, Username, Password, no_of_crimes); //check
            //officer_ID_textBox.Text = counter.ToString();

            newoff.officer_ID = officer_ID_textBox.Text;
            newoff.officer_Name = Officer_Name_textBox.Text;
            newoff.no_of_assigned_crimes = no_crimes_textBox1.Text;
            newoff.officer_username = officer_usernmae_textBox.Text;
            newoff.officer_password = officer_password_textBox.Text;



            olist.Add(newoff);
            if (newoff.add_officer(officer_ID_textBox.Text, Officer_Name_textBox.Text, no_crimes_textBox1.Text, officer_usernmae_textBox.Text, officer_password_textBox.Text) == true)
            {
                newoff.Officers_IDs(officer_ID_textBox.Text);

                int x = officer_dataGridView1.Rows.Add();
                officer_dataGridView1.Rows[x].Cells[0].Value = ID;
                officer_dataGridView1.Rows[x].Cells[1].Value = Name;
                officer_dataGridView1.Rows[x].Cells[2].Value = no_of_crimes;
                officer_dataGridView1.Rows[x].Cells[3].Value = Username;
                officer_dataGridView1.Rows[x].Cells[4].Value = Password;
                // counter++;
                clear();
            }
        }



        private void officer_delete_Click(object sender, EventArgs e)
        {
            try
            {
                Officer_selected_row = officer_dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow newDataRow = officer_dataGridView1.Rows[Officer_selected_row];
                Officer of = new Officer(Officer_Name_textBox.Text, officer_usernmae_textBox.Text, officer_password_textBox.Text, no_crimes_textBox1.Text);

                string check = newDataRow.Cells[0].Value.ToString();
                of.delete_officer(check);
                officer_dataGridView1.Rows.RemoveAt(Officer_selected_row);
                clear();

            }
            catch (Exception)
            {

            }
        }

        private void officer_update_Click(object sender, EventArgs e)
        {
            Officer_selected_row = officer_dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow newDataRow = officer_dataGridView1.Rows[Officer_selected_row];

            Officer of = new Officer(Officer_Name_textBox.Text, officer_usernmae_textBox.Text, officer_password_textBox.Text, no_crimes_textBox1.Text);
            string check = newDataRow.Cells[0].Value.ToString();
           // MessageBox.Show(check);
            try
            {
                of.update_officer(check, Officer_Name_textBox.Text, officer_usernmae_textBox.Text, officer_password_textBox.Text);

                newDataRow.Cells[0].Value = officer_ID_textBox.Text;
                newDataRow.Cells[1].Value = Officer_Name_textBox.Text;
                // newDataRow.Cells[2].Value = officer_crimes_comboBox.SelectedItem.ToString();
                newDataRow.Cells[3].Value = officer_usernmae_textBox.Text;
                newDataRow.Cells[4].Value = officer_password_textBox.Text;

                clear();
            }
            catch (Exception)
            {

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            officer_dataGridView1.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load("Officers.xml");
                XmlNodeList list = doc.GetElementsByTagName("Officer");

                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList childrens = list[i].ChildNodes;
                    string id = childrens[0].Name;
                    string ivalue = childrens[0].InnerText;

                    string name = childrens[1].Name;
                    string nvalue = childrens[1].InnerText;

                    string no_crimes = childrens[2].Name;
                    string cvalue = childrens[2].InnerText;

                    string username = childrens[3].Name;
                    string uvalue = childrens[3].InnerText;

                    string password = childrens[4].Name;
                    string pvalue = childrens[4].InnerText;

                    if (ivalue == officer_search_textBox.Text)
                    {
                        officer_dataGridView1.Rows.Add(new string[] { ivalue, nvalue, cvalue, uvalue, pvalue });
                        break;
                    }
                    else
                    {
                        // MessageBox.Show("Doesn't exist");
                        continue;
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void officer_back_btn_Click(object sender, EventArgs e)
        {
            _4_Admin_functions f = new _4_Admin_functions();
            this.Hide();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void officer_dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void officer_dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Officer_selected_row = e.RowIndex;
            DataGridViewRow row = officer_dataGridView1.Rows[Officer_selected_row];

            // display datagridview selected row data into textboxes
            officer_ID_textBox.Text = row.Cells[0].Value.ToString();
            Officer_Name_textBox.Text = row.Cells[1].Value.ToString();
            no_crimes_textBox1.Text = row.Cells[2].Value.ToString();
            officer_usernmae_textBox.Text = row.Cells[3].Value.ToString();
            officer_password_textBox.Text = row.Cells[4].Value.ToString();
        }

        private void Officer_Page_Admin_Panel_btn_Click(object sender, EventArgs e)
        {
            _11_admin_add_admin f = new _11_admin_add_admin();
            this.Hide();
            f.Show();
        }

        private void Officer_Page_Criminal_Panel_btn_Click(object sender, EventArgs e)
        {
            _6_Admin_Set__Criminals f = new _6_Admin_Set__Criminals();
            this.Hide();
            f.Show();
        }

        private void Officer_Page_Case_Panel_btn_Click(object sender, EventArgs e)
        {
            _7_Admin_Set_Case f = new _7_Admin_Set_Case();
            this.Hide();
            f.Show();
        }

        private void _5_admin_set_officer_Load(object sender, EventArgs e)
        {

        }
        public void read_IDs()
        {
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load("Officers_ID.xml");
                XmlNodeList list = doc.GetElementsByTagName("IDs");

                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList childrens = list[i].ChildNodes;

                    string id = childrens[0].Name;
                    string ivalue = childrens[0].InnerText;
                    int idd = int.Parse(ivalue);
                    officer_ID_textBox.Text = (idd + 1).ToString();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
