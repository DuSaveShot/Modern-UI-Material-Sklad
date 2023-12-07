using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_UI_Material_Sklad
{
    public partial class Form_User_Selector : Form
    {
        public Form_User_Selector()
        {
            InitializeComponent();
        }

        private void Form_User_Selector_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel16_MouseEnter(object sender, EventArgs e)
        {
            panel16.BackColor = Color.FromArgb(22, 40, 30);
            pictureBox8.BackColor = Color.FromArgb(22, 40, 30);
        }

        private void panel16_MouseLeave(object sender, EventArgs e)
        {
            panel16.BackColor = Color.FromArgb(17, 53, 71);
            pictureBox8.BackColor = Color.FromArgb(17, 53, 71);
        }

        private void panel15_MouseEnter_1(object sender, EventArgs e)
        {
            panel15.BackColor = Color.Khaki;
            label6.ForeColor = Color.Black;
        }

        private void panel15_MouseLeave_1(object sender, EventArgs e)
        {
            panel15.BackColor = Color.FromArgb(17, 53, 71);
            label6.ForeColor = Color.White;
        }

        private void panel13_MouseEnter_1(object sender, EventArgs e)
        {
            panel13.BackColor = Color.SpringGreen;
        }

        private void panel13_MouseLeave_1(object sender, EventArgs e)
        {
            panel13.BackColor = Color.FromArgb(17, 53, 71);
        }

        private void panel13_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Closed += (s, args) => this.Close();
            Form1.Show();
        }

        private void panel15_Click_1(object sender, EventArgs e)
        {
            userControl_MainFrame1.Visible = false;
            tab_Selector_Loader1.Visible = true;
        }

        private void panel16_Click(object sender, EventArgs e)
        {
            userControl_MainFrame1.Visible = true;
            tab_Selector_Loader1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_User_Selector_DragEnter(object sender, DragEventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void Form_User_Selector_ResizeBegin(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void Form_User_Selector_ResizeEnd(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panel15_Click_1(sender, e);
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            panel15.BackColor = Color.Khaki;
            panel15_MouseEnter_1(sender, e);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            panel15.BackColor = Color.FromArgb(17, 53, 71);
            panel15_MouseLeave_1(sender, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Closed += (s, args) => this.Close();
            Form1.Show();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            panel13.BackColor = Color.SpringGreen;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            panel13.BackColor = Color.FromArgb(17, 53, 71);
        }
    }
}
