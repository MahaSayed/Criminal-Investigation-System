using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Files_Trial
{
    public partial class _4_Admin_functions : Form
    {
        public _4_Admin_functions()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            this.Hide();
            F.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void Officer_btn_Click(object sender, EventArgs e)
        {
            _5_admin_set_officer f = new _5_admin_set_officer();
            this.Hide();
            f.Show();
        }

        private void criminal_btn_Click(object sender, EventArgs e)
        {
            _6_Admin_Set__Criminals criminal = new _6_Admin_Set__Criminals();
            this.Hide();
            criminal.Show();
        }

        private void case_btn_Click(object sender, EventArgs e)
        {
            _7_Admin_Set_Case f = new _7_Admin_Set_Case();
            this.Hide();
            f.Show();
        }

        private void admin_btn_Click(object sender, EventArgs e)
        {
            _11_admin_add_admin f = new _11_admin_add_admin();
            this.Hide();
            f.Show();
        }
    }
}
