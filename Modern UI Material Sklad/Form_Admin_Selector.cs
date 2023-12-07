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
    public partial class Form_Admin_Selector : Form
    {
        public Form_Admin_Selector()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel15_MouseEnter(object sender, EventArgs e)
        {
            panel15.BackColor = Color.Khaki;
            label6.ForeColor = Color.Black;
        }

        private void panel15_MouseLeave(object sender, EventArgs e)
        {
            panel15.BackColor = Color.FromArgb(17, 53, 71);
            label6.ForeColor = Color.White;
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            tab_Selector1.Visible = true;
            userControl_MainFrame1.Visible = false;
            userControl_Users1.Visible = false;
        }

        private void panel14_MouseEnter(object sender, EventArgs e)
        {
            panel14.BackColor = Color.LightSkyBlue;
        }

        private void panel14_MouseLeave(object sender, EventArgs e)
        {
            panel14.BackColor = Color.FromArgb(17, 53, 71);
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            userControl_MainFrame1.Visible = false;
            tab_Selector1.Visible = false;
            userControl_Users1.Visible = true;
        }

        private void panel13_MouseEnter(object sender, EventArgs e)
        {
            panel13.BackColor = Color.SpringGreen;
        }

        private void panel13_MouseLeave(object sender, EventArgs e)
        {
            panel13.BackColor = Color.FromArgb(17, 53, 71);
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Closed += (s, args) => this.Close();
            Form1.Show();
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

        private void panel16_Click(object sender, EventArgs e)
        {
            userControl_MainFrame1.Visible = true;
            tab_Selector1.Visible = false;
            userControl_Users1.Visible = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Admin_Selector_ResizeBegin(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void Form_Admin_Selector_ResizeEnd(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void Form_Admin_Selector_DragEnter(object sender, DragEventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panel15_Click(sender, e);
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            panel15.BackColor = Color.Khaki;
            panel15_MouseEnter(sender, e);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            panel15.BackColor = Color.FromArgb(17, 53, 71);
            panel15_MouseLeave(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            userControl_MainFrame1.Visible = false;
            tab_Selector1.Visible = false;
            userControl_Users1.Visible = true;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            panel14.BackColor = Color.LightSkyBlue;

        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            panel14.BackColor = Color.FromArgb(17, 53, 71);
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
