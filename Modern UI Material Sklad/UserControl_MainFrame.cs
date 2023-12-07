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
    public partial class UserControl_MainFrame : UserControl
    {
        public UserControl_MainFrame()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
            label2.Text = DateTime.Now.ToString("yyyy.MM.dd");

        }
    }
}
