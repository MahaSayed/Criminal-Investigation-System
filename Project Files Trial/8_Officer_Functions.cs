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
    public partial class _8_Officer_Functions : Form
    {
        public _8_Officer_Functions(string username)
        {
            InitializeComponent();
            string send_username = username;
            label2.Text = send_username;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _9_officer_add_result f = new _9_officer_add_result(label2.Text);
            this.Hide();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _12_officer_view_cases f = new _12_officer_view_cases(label2.Text);
            this.Hide();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _10_officer_view_suspects f = new _10_officer_view_suspects(label2.Text);
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _14_View_Charts f = new _14_View_Charts(label2.Text);
            this.Hide();
            f.Show();
        }
    }
}
