using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Project_Files_Trial
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
            player.URL = "music.mp3";
            player.controls.play();
        }

        private void Welcome_Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void welcome_admin_btn_Click(object sender, EventArgs e)
        {
            _2_Admin_LOGIN f = new _2_Admin_LOGIN();
            this.Hide();
            f.Show();
        }

        private void welcome_officer_btn_Click(object sender, EventArgs e)
        {
            _3_Officer_LOGIN f = new _3_Officer_LOGIN();
            this.Hide();
            f.Show();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
