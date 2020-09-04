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
    public partial class Slideshow : Form
    {
        public Slideshow(string usernamer)
        {
            InitializeComponent();
            label4.Text = usernamer;
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void button6_Click(object sender, EventArgs e)
        {
            _14_View_Charts f = new _14_View_Charts(label4.Text);
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _10_officer_view_suspects f = new _10_officer_view_suspects(label4.Text);
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
                   timer1.Start();
        }

        private void Slideshow_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox10.Visible ==true )
            {
                pictureBox10.Visible = false;
                pictureBox9.Visible = true;
            }
          else  if (pictureBox9.Visible == true)
            {
                pictureBox9.Visible = false;
                pictureBox8.Visible = true;
            }
            else if (pictureBox8.Visible == true)
            {
                pictureBox8.Visible = false;
                pictureBox7.Visible = true;
            }
            else if (pictureBox7.Visible == true)
            {
                pictureBox7.Visible = false;
                pictureBox6.Visible = true;
            }
            else if (pictureBox6.Visible == true)
            {
                pictureBox6.Visible = false;
                pictureBox5.Visible = true;
            }
            else if (pictureBox5.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox4.Visible = true;
            }
            else if (pictureBox4.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;
            }
            else if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox10.Visible = true;
            }
        }
    }
}
