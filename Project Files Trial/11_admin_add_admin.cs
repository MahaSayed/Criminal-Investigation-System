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
    public partial class _11_admin_add_admin : Form
    {
        public _11_admin_add_admin()
        {
            InitializeComponent();
            XmlDocument doc = new XmlDocument();
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


                    if (dataGridView1.ColumnCount == 0)
                    {
                        dataGridView1.Columns.Add("Username", username);
                        dataGridView1.Columns.Add("Password", password);
                    }
                    dataGridView1.Rows.Add(new string[] { uservalue, passvalue });
                }
            }
            catch (Exception)
            {

            }
        }

        private void add_button5_Click(object sender, EventArgs e)
        {
            admin admin = new admin(textBox1.Text, textBox2.Text);
            admin.add_admin(textBox1.Text, textBox2.Text);

            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[n].Cells[1].Value = textBox2.Text;
            clear();
        }

        private void update_button6_Click(object sender, EventArgs e)
        {
            int selected_row = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow newDataRow = dataGridView1.Rows[selected_row];

            string check = newDataRow.Cells[0].Value.ToString();
            admin admin = new admin(textBox1.Text, textBox2.Text);
            admin.update_admin(check, textBox1.Text, textBox2.Text);
            try
            {
                newDataRow.Cells[0].Value = textBox1.Text;
                newDataRow.Cells[1].Value = textBox2.Text;
            }
            catch (Exception)
            {

            }
            clear();
        }

        private void delete_button7_Click(object sender, EventArgs e)
        {
            try
            {

                int selected_row = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow newDataRow = dataGridView1.Rows[selected_row];
                string check = newDataRow.Cells[0].Value.ToString();
                admin admin = new admin(textBox1.Text, textBox2.Text);
                admin.delete_admin(check);
                dataGridView1.Rows.RemoveAt(selected_row);

            }
            catch (Exception)
            {

            }
            clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected_row = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selected_row];

            // display datagridview selected row data into textboxes
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
        }

        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _4_Admin_functions f = new _4_Admin_functions();
            this.Hide();
            f.Show();
        }

        private void Officer_Page_Admin_Panel_btn_Click(object sender, EventArgs e)
        {
            _5_admin_set_officer f = new _5_admin_set_officer();
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
    }
}
