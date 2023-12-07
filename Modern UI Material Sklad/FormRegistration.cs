using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_UI_Material_Sklad
{
    public partial class FormRegistration : Form
    {
        connection dataBase = new connection();
        int CheckWrite = 0;
        int themeApp;

        public FormRegistration(int s)
        {
            InitializeComponent();
            themeApp = s;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void FormRegistration_Load(object sender, EventArgs e)
        {
            if (themeApp == 1)
            {
                panel23.BackColor = Color.Gainsboro;
                panel24.BackColor = Color.Gainsboro;
                panel21.BackColor = Color.PapayaWhip;
                label9.ForeColor = Color.Black;
                label10.ForeColor = Color.Black;
                label6.ForeColor = Color.Black;
                label12.ForeColor = Color.Black;
                label13.ForeColor = Color.Black;
            }
            else
            {
                panel23.BackColor = Color.FromArgb(17, 53, 71);
                panel24.BackColor = Color.FromArgb(17, 53, 71);
                panel21.BackColor = Color.FromArgb(30, 30, 30);
                label9.ForeColor = Color.White;
                label10.ForeColor = Color.White;
                label6.ForeColor = Color.White;
                label12.ForeColor = Color.White;
                label13.ForeColor = Color.White;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Form1 = new Form1();
            Form1.Closed += (s, args) => this.Close();
            Form1.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (CheckWrite == 0)
            {
                textBox3.PasswordChar = '\0';
                CheckWrite++;
            }
            else
            {
                textBox3.PasswordChar = '*';
                CheckWrite--;
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Text = null;
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = null;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox4.ForeColor = Color.White;
                panel16.Visible = false;
            }
            catch { }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox3.ForeColor = Color.White;
                panel15.Visible = false;
            }
            catch { }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Lime;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Black;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Yellow;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Подтвердить?", "Очистить поля", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                textBox4.Text = "";
                textBox3.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Введите логин";
            }

            if (textBox3.Text == "")
            {
                textBox3.Text = "Введите пароль";
            }

            if (textBox4.Text == "Введите логин")
            {
                panel16.Visible = true;
                textBox4.Focus();
                return;
            }

            if (textBox3.Text == "Введите пароль")
            {
                panel15.Visible = true;
                textBox3.Focus();
                return;
            }


            if (textBox4.Text.Length >= 5 && textBox3.Text.Length >= 5)
            {
                var Login = textBox4.Text;
                var Password = textBox3.Text;
                var Role = "1";

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dataTable = new DataTable();
                string querystring = $"select Логин FROM Users WHERE Логин = '{Login}'";
                SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count == 0)
                {
                    SqlDataAdapter adapter2 = new SqlDataAdapter();
                    DataTable dataTable2 = new DataTable();
                    string querystring2 = $"INSERT INTO Users(Логин, Пароль, [Тип пользователя]) VALUES('{Login}', '{Password}', {Role})";
                    SqlCommand command2 = new SqlCommand(querystring2, dataBase.getConnection());
                    adapter2.SelectCommand = command2;
                    adapter2.Fill(dataTable2);
                    MessageBox.Show($"Пользователь {Login} успешно добавлен", "Сообщение");

                    // Переходим на окно авторизации, чтобы пользователь не выполнял множество регистраций =) 
                    this.Hide();
                    var Form1 = new Form1();
                    Form1.Closed += (s, args) => this.Close();
                    Form1.Show();
                }
                else
                {
                    MessageBox.Show("Пользователь с таким логином уже существует, выберите другой", "Сообщение");
                }
            }
            else
            {
                MessageBox.Show("Логин и пароль должны состоять не менее из 5 символов, попробуйте еще раз", "Предупреждение");
            }
        }

        private void panel24_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FormRegistration_ResizeBegin(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void FormRegistration_ResizeEnd(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void FormRegistration_DragEnter(object sender, DragEventArgs e)
        {
            this.Opacity = 0.5;
        }
    }
}
