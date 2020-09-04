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
    public partial class _7_Admin_Set_Case : Form
    {
        public _7_Admin_Set_Case()
        {
            InitializeComponent();
            Check_Officer();
            Read_Types();
            Read_Suspects();
            read();
        }
        int counter = 0;
        List<Crime> list_crime = new List<Crime>();
        //Dictionary<String, Crime> Dic_crime = new Dictionary<String, Crime>();
        List<string> _Suspect = new List<string>();
        List<string> _itemsfound = new List<string>();

        public void Check_Officer()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Officers.xml");
                XmlNodeList list = doc.GetElementsByTagName(("Officer"));
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList children = list[i].ChildNodes;
                    string id = children[0].Name;
                    string idvalue = children[0].InnerText;
                    string number_assignes_crimes = children[2].Name;
                    string ass_crimes = children[2].InnerText;
                    if (int.Parse(ass_crimes) < 10)
                    {
                        if (!comboBox1OFFICERID.Items.Contains(idvalue))
                        {
                            comboBox1OFFICERID.Items.Add(idvalue);
                        }
                    }
                }

            }

            catch (Exception)
            {

            }
        }

        public void Read_Suspects()
        {
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

                    comboBox3SUSPECTS.Items.Add(namevalue);


                }
            }
            catch (Exception)
            {

            }
        }
        private void read()
        {
            try
            {
                dataGridViewCrimeee.Rows.Clear();
                XmlDataDocument dc = new XmlDataDocument();
                dc.Load("CRIMEDATA.xml");
                XmlNodeList list = dc.GetElementsByTagName("crime");

                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList child = list[i].ChildNodes;

                    string crimeID = child[0].Name;
                    string civalue = child[0].InnerText;
                    counter = list.Count + 1;

                    string typeid = child[1].Name;
                    string tivalue = child[1].InnerText;

                    string status = child[2].Name;
                    string ssvalue = child[2].InnerText;

                    string area = child[3].Name;
                    string aavalue = child[3].InnerText;


                    string descrip = child[4].Name;
                    string ddvalue = child[4].InnerText;

                    string officerid = child[5].Name;
                    string oofvalue = child[5].InnerText;

                    string itemf = child[6].Name;
                    string itfvalue = child[6].InnerText;

                    string suspect = child[7].Name;
                    string susvalue = child[7].InnerText;

                    //image
                    string imageee = child[8].Name;
                    string imgvalue = child[8].InnerText;


                    if (dataGridViewCrimeee.ColumnCount == 0)
                    {
                        dataGridViewCrimeee.Columns.Add("CrimeID", crimeID);
                        dataGridViewCrimeee.Columns.Add("TypeID", typeid);
                        dataGridViewCrimeee.Columns.Add("Status", status);
                        dataGridViewCrimeee.Columns.Add("Description", descrip);
                        dataGridViewCrimeee.Columns.Add("OfficerID", officerid);
                        dataGridViewCrimeee.Columns.Add("ItemsFound", itemf);
                        dataGridViewCrimeee.Columns.Add("Suspect", suspect);
                        dataGridViewCrimeee.Columns.Add("Imagee", imageee);
                    }
                    dataGridViewCrimeee.Rows.Add(new string[] { civalue, tivalue, ssvalue, aavalue, ddvalue, oofvalue, itfvalue, susvalue, imgvalue });
                }
            }
            catch (Exception)
            {

            }
        }

        public void Read_Types()
        {
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load("Types.xml");
                XmlNodeList list = doc.GetElementsByTagName("Type");
                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList children = list[i].ChildNodes;
                    string id = children[0].Name;
                    string idvalue = children[0].InnerText;

                    string Name = children[1].Name;
                    string namevalue = children[1].InnerText;

                    comboBox2TYPEID.Items.Add(idvalue);


                }
            }
            catch (Exception)
            {

            }
        }

        private void _7_Admin_Set_Case_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _itemsfound.Add(textBoxItemfound.Text);
            textBoxItemfound.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _Suspect.Add(comboBox3SUSPECTS.SelectedItem.ToString());
            comboBox3SUSPECTS.SelectedIndex = -1;
        }

        private void button1Uploadimage_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                pictureBox1ImageCrime.ImageLocation = openFileDialog1.FileName;
                string TheImageFile = openFileDialog1.FileName;
                Image TheImage = Image.FromFile(TheImageFile);
                pictureBox1ImageCrime.Image = TheImage;

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
                doc.Load("Cases_ID.xml");
                XmlNodeList list = doc.GetElementsByTagName("IDs");

                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList childrens = list[i].ChildNodes;

                    string id = childrens[0].Name;
                    string ivalue = childrens[0].InnerText;
                    int idd = int.Parse(ivalue);
                    textBox1CrimeID.Text = (idd + 1).ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        private void button1AddCrime_Click(object sender, EventArgs e)
        {
            read_IDs();

            int n = dataGridViewCrimeee.Rows.Add();
            dataGridViewCrimeee.Rows[n].Cells[0].Value = textBox1CrimeID.Text;
            dataGridViewCrimeee.Rows[n].Cells[1].Value = comboBox2TYPEID.SelectedItem.ToString();
            dataGridViewCrimeee.Rows[n].Cells[2].Value = Status_textBox1.Text;
            dataGridViewCrimeee.Rows[n].Cells[3].Value = textBox6Area.Text;
            dataGridViewCrimeee.Rows[n].Cells[4].Value = textBox5Descrip.Text;
            dataGridViewCrimeee.Rows[n].Cells[5].Value = comboBox1OFFICERID.SelectedItem.ToString();

            string ItemsFoundString = _itemsfound[0];
            for (int q = 1; q < _itemsfound.Count; q++)
            {
                ItemsFoundString += " , ";
                ItemsFoundString += _itemsfound[q];

            }

            dataGridViewCrimeee.Rows[n].Cells[6].Value = ItemsFoundString;

            string suspectsString = _Suspect[0];
            for (int q = 1; q < _Suspect.Count; q++)
            {
                suspectsString += " , ";
                suspectsString += _Suspect[q];
            }
            dataGridViewCrimeee.Rows[n].Cells[7].Value = suspectsString;
            string image_Text = openFileDialog1.FileName;
            dataGridViewCrimeee.Rows[n].Cells[8].Value = image_Text;
            Crime c = new Crime(textBox5Descrip.Text, comboBox1OFFICERID.SelectedItem.ToString(), comboBox2TYPEID.SelectedItem.ToString(), textBox6Area.Text, Status_textBox1.Text, image_Text, _Suspect, _itemsfound);
            //textBox1CrimeID.Text = counter.ToString();
            c.add_crime(textBox1CrimeID.Text, textBox5Descrip.Text, comboBox1OFFICERID.SelectedItem.ToString(), comboBox2TYPEID.SelectedItem.ToString(), textBox6Area.Text, Status_textBox1.Text, image_Text, _Suspect, _itemsfound);
            c.Cases_IDs(textBox1CrimeID.Text);
            Officer of = new Officer();
            of.officer_ID = comboBox1OFFICERID.SelectedItem.ToString();
            c.Assign_officers(of);
            clear();
        }

        private void button2EditCrime_Click(object sender, EventArgs e)
        {
            int selected_row = dataGridViewCrimeee.CurrentCell.RowIndex;
            DataGridViewRow newDataRow = dataGridViewCrimeee.Rows[selected_row];
            string image_Text = newDataRow.Cells[7].Value.ToString();

            //string imageText = openFileDialog1.FileName;

            Crime c = new Crime(textBox5Descrip.Text, comboBox1OFFICERID.SelectedItem.ToString(), comboBox2TYPEID.SelectedItem.ToString(), textBox6Area.Text, Status_textBox1.Text, image_Text, _Suspect, _itemsfound);
            try
            {
                c.Update(textBox1CrimeID.Text, textBox6Area.Text, Status_textBox1.Text, textBox5Descrip.Text, comboBox1OFFICERID.SelectedItem.ToString(), _itemsfound, _Suspect);


                dataGridViewCrimeee.SelectedRows[0].Cells[0].Value = textBox1CrimeID.Text;
                dataGridViewCrimeee.SelectedRows[0].Cells[1].Value = comboBox2TYPEID.SelectedItem.ToString();
                dataGridViewCrimeee.SelectedRows[0].Cells[2].Value = Status_textBox1.Text;
                dataGridViewCrimeee.SelectedRows[0].Cells[3].Value = textBox6Area.Text;
                dataGridViewCrimeee.SelectedRows[0].Cells[4].Value = textBox5Descrip.Text;
                dataGridViewCrimeee.SelectedRows[0].Cells[5].Value = comboBox1OFFICERID.SelectedItem.ToString();
                foreach (var item in _itemsfound)
                {
                    dataGridViewCrimeee.SelectedRows[0].Cells[6].Value += item;
                }

                foreach (var item in _Suspect)
                {
                    dataGridViewCrimeee.SelectedRows[0].Cells[7].Value += item;
                }
                //dataGridViewCrimeee.SelectedRows[0].Cells[6].Value = comboBox3SUSPECTS.SelectedItem.ToString();
                dataGridViewCrimeee.SelectedRows[0].Cells[8].Value = image_Text;
                MessageBox.Show("Updated!!");
                clear();
            }
            catch (Exception)
            { }
        }

        private void button3DeleteCrime_Click(object sender, EventArgs e)
        {
            int selected_row = dataGridViewCrimeee.CurrentCell.RowIndex;
            DataGridViewRow newDataRow = dataGridViewCrimeee.Rows[selected_row];
            string image_Text = newDataRow.Cells[4].Value.ToString();
            Crime c = new Crime(textBox5Descrip.Text, comboBox1OFFICERID.SelectedItem.ToString(), comboBox2TYPEID.SelectedItem.ToString(), textBox6Area.Text, Status_textBox1.Text, image_Text, _Suspect, _itemsfound);
            c.Delete(textBox1CrimeID.Text);
            dataGridViewCrimeee.Rows.RemoveAt(selected_row);
            MessageBox.Show("DELETED");
            clear();
        }

        private void clear()
        {
            textBox1CrimeID.Clear();
            comboBox2TYPEID.SelectedIndex = -1;
            //textBox4Status.Clear();
            textBox6Area.Clear();
            textBox5Descrip.Clear();
            comboBox1OFFICERID.SelectedIndex = -1;
            textBoxItemfound.Clear();
            comboBox3SUSPECTS.SelectedIndex = -1;
            pictureBox1ImageCrime.Image = null;

        }

        private void buttonSearchhh_Click(object sender, EventArgs e)
        {
            dataGridViewCrimeee.Rows.Clear();
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load("CRIMEDATA.xml");
                XmlNodeList list = doc.GetElementsByTagName("crime");

                for (int i = 0; i < list.Count; i++)
                {
                    XmlNodeList child = list[i].ChildNodes;
                    string crimeID = child[0].Name;
                    string civalue = child[0].InnerText;

                    string typeid = child[1].Name;
                    string tivalue = child[1].InnerText;

                    string status = child[2].Name;
                    string ssvalue = child[2].InnerText;

                    string area = child[3].Name;
                    string aavalue = child[3].InnerText;


                    string descrip = child[4].Name;
                    string ddvalue = child[4].InnerText;

                    string officerid = child[5].Name;
                    string oofvalue = child[5].InnerText;

                    string itemf = child[6].Name;
                    string itfvalue = child[6].InnerText;

                    string suspect = child[7].Name;
                    string susvalue = child[7].InnerText;

                    //image
                    string imageee = child[8].Name;
                    string imgvalue = child[8].InnerText;
                    if (civalue == textBoxSearchhh.Text)
                    {
                        dataGridViewCrimeee.Rows.Add(new string[] { civalue, tivalue, aavalue, ddvalue, oofvalue, itfvalue, susvalue, imgvalue });
                        break;
                    }
                    else
                    {
                        continue;
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void dataGridViewCrimeee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected_row = e.RowIndex;
            DataGridViewRow row = dataGridViewCrimeee.Rows[selected_row];

            // display datagridview selected row data into textboxes
            textBox1CrimeID.Text = row.Cells[0].Value.ToString();
            comboBox2TYPEID.Text = row.Cells[1].Value.ToString();
            Status_textBox1.Text = row.Cells[2].Value.ToString();
            textBox6Area.Text = row.Cells[3].Value.ToString();
            textBox5Descrip.Text = row.Cells[4].Value.ToString();
            comboBox1OFFICERID.Text = row.Cells[5].Value.ToString();

            foreach (var item in _itemsfound)
            {
                textBoxItemfound.Text = row.Cells[6].Value.ToString();
            }
            // comboBox3SUSPECTS.Text = row.Cells[7].Value.ToString();
            String TheImageFile = row.Cells[8].Value.ToString();
            Image TheImage = Image.FromFile(TheImageFile);
            pictureBox1ImageCrime.Image = TheImage;
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
            _5_admin_set_officer f = new _5_admin_set_officer();
            this.Hide();
            f.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewCrimeee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
