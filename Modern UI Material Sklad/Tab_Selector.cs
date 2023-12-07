using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_UI_Material_Sklad
{
    public partial class Tab_Selector : UserControl
    {
        public Tab_Selector()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Bitmap.FromFile("../../Images/return_full.png");

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Bitmap.FromFile("../../Images/return.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frame_DB_Boss1.Visible = false;
            frame_DB_List1.Visible = false;
            frame_DB_Loader1.Visible = false;
            frame_DB_Sklad1.Visible = false;
            frame_DB_Sklad_Parts1.Visible = false;
            frame_DB_Tovar1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frame_DB_Boss1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frame_DB_List1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frame_DB_Loader1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frame_DB_Sklad1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frame_DB_Sklad_Parts1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frame_DB_Tovar1.Visible = true;
        }
    }
}
