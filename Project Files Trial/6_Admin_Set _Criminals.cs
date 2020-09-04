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
using System.Xml.Serialization;
using System.Xml.Linq;
using System.IO;
using System.Collections;

namespace Project_Files_Trial
{
    public partial class _6_Admin_Set__Criminals : Form
    {
        int selected_row;
        List<involved_people> listi = new List<involved_people>();
        Dictionary<string, involved_people> Dic_involved = new Dictionary<string, involved_people>();
        DataTable dt = new DataTable();
        int counter = 0;
        public _6_Admin_Set__Criminals()
        {
            InitializeComponent();
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
                    counter = list.Count + 1;
                    string Name = children[1].Name;
                    string namevalue = children[1].InnerText;

                    string age = children[2].Name;
                    string agevalue = children[2].InnerText;

                    string location = children[3].Name;
                    string locationvalue = children[3].InnerText;

                    string image = children[4].Name;
                    string image_Text = children[4].InnerText;

                    string points = children[5].Name;
                    string pointsvalue = children[5].InnerText;

                    if (dataGridView1.ColumnCount == 0)
                    {
                        dataGridView1.Columns.Add("ID", id);
                        dataGridView1.Columns.Add("Name", Name);
                        dataGridView1.Columns.Add("Age", age);
                        dataGridView1.Columns.Add("Location", location);
                        dataGridView1.Columns.Add("Image", image);
                        dataGridView1.Columns.Add("Points", points);
                    }
                    dataGridView1.Rows.Add(new string[] { idvalue, namevalue, agevalue, locationvalue, image_Text, pointsvalue});
                }
            }
            catch (Exception)
            {

            }
        }

        public void read_IDs()
        {
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load("Suspects_ID.xml");
                XmlNodeList list = doc.GetElementsByTagName("IDs");

                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList childrens = list[i].ChildNodes;

                    string id = childrens[0].Name;
                    string ivalue = childrens[0].InnerText;
                    int idd = int.Parse(ivalue);
                    ID_txt.Text = (idd + 1).ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string points = Points_textBox.Text;
            string image_Text = openFileDialog1.FileName;
            involved_people inp = new involved_people(Age_txt.Text, Name_txt.Text, Location_txt.Text, image_Text, points);
           // ID_txt.Text = counter.ToString();
            inp.name = Name_txt.Text;
            inp.age = Age_txt.Text;
            inp.location = Location_txt.Text;
            inp.image = image_Text;
            listi.Add(inp);
            read_IDs();

            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = ID_txt.Text;
            dataGridView1.Rows[n].Cells[1].Value = Name_txt.Text;
            dataGridView1.Rows[n].Cells[2].Value = Age_txt.Text;
            dataGridView1.Rows[n].Cells[3].Value = Location_txt.Text;
            dataGridView1.Rows[n].Cells[4].Value = image_Text;
            dataGridView1.Rows[n].Cells[5].Value = Points_textBox.Text;
            inp.Suspects_IDs(ID_txt.Text);
            inp.add_suspect_in_list(ID_txt.Text, Age_txt.Text, Name_txt.Text, Location_txt.Text, image_Text, points);
            clear();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            selected_row = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow newDataRow = dataGridView1.Rows[selected_row];
            string image_Text = newDataRow.Cells[4].Value.ToString();

            // newDataRow.Cells[3].Value = image_Text;
            involved_people inp = new involved_people(Age_txt.Text, Name_txt.Text, Location_txt.Text, image_Text, Points_textBox.Text);
            ////////////////////////// lazm a check bl id ////////////////////
            string check = newDataRow.Cells[0].Value.ToString();
           // MessageBox.Show(check);
            try
            {
                inp.update_suspect(check, Name_txt.Text, Age_txt.Text, Location_txt.Text, Points_textBox.Text);

                newDataRow.Cells[0].Value = ID_txt.Text;
                newDataRow.Cells[1].Value = Name_txt.Text;
                newDataRow.Cells[2].Value = Age_txt.Text;
                newDataRow.Cells[3].Value = Location_txt.Text;
                newDataRow.Cells[5].Value = Points_textBox.Text;
                clear();

            }
            catch (Exception)
            {

            }
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                //this.Text = openFileDialog1.FileName;
                String TheImageFile = openFileDialog1.FileName;

                Image TheImage = Image.FromFile(TheImageFile);
                pictureBox1.Image = TheImage;


            }
            catch (Exception)
            {

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {


                selected_row = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow newDataRow = dataGridView1.Rows[selected_row];
                string image_Text = newDataRow.Cells[4].Value.ToString();
                involved_people inp = new involved_people(Age_txt.Text, Name_txt.Text, Location_txt.Text, image_Text, Points_textBox.Text);
                /////////////////// lazm a check bl id////////////
                string check = newDataRow.Cells[0].Value.ToString();
                inp.delete_suspect(check);
                dataGridView1.Rows.RemoveAt(selected_row);
                clear();
                
            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
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
                    if (idvalue == Search.Text)
                    {
                        dataGridView1.Rows.Add(new string[] { idvalue, namevalue, agevalue, locationvalue, image_Text });
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void clear()
        {
            ID_txt.Clear();
            Name_txt.Clear();
            Age_txt.Clear();
            Location_txt.Clear();
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
            Points_textBox.Clear();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_row = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selected_row];

            // display datagridview selected row data into textboxes
            ID_txt.Text = row.Cells[0].Value.ToString();
            Name_txt.Text = row.Cells[1].Value.ToString();
            Age_txt.Text = row.Cells[2].Value.ToString();
            Location_txt.Text = row.Cells[3].Value.ToString();

            String TheImageFile = row.Cells[4].Value.ToString();

            Image TheImage = Image.FromFile(TheImageFile);
            pictureBox1.Image = TheImage;
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selected_row = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selected_row];

            // display datagridview selected row data into textboxes
            ID_txt.Text = row.Cells[0].Value.ToString();
            Name_txt.Text = row.Cells[1].Value.ToString();
            Age_txt.Text = row.Cells[2].Value.ToString();
            Location_txt.Text = row.Cells[3].Value.ToString();

            String TheImageFile = row.Cells[4].Value.ToString();
            Image TheImage = Image.FromFile(TheImageFile);
            pictureBox1.Image = TheImage;

            Points_textBox.Text = row.Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void Officer_Page_Admin_Panel_btn_Click(object sender, EventArgs e)
        {
            _5_admin_set_officer f = new _5_admin_set_officer();
            this.Hide();
            f.Show();
        }

        private void Officer_Page_Criminal_Panel_btn_Click(object sender, EventArgs e)
        {
            _11_admin_add_admin f = new _11_admin_add_admin();
            this.Hide();
            f.Show();
        }

        private void Officer_Page_Case_Panel_btn_Click(object sender, EventArgs e)
        {
            _7_Admin_Set_Case f = new _7_Admin_Set_Case();
            this.Hide();
            f.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _6_Admin_Set__Criminals_Load(object sender, EventArgs e)
        {

        }
    }
}
