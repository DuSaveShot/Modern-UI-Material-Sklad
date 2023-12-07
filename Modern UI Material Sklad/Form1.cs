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
    public partial class Form1 : Form
    {
        connection dataBase = new connection();
        int Attempt = 0;
        int ThemeSet = 0;
        int CountTimer = 15;
        int CheckWrite = 0;
        int pw;
        bool hided;

        public Form1()
        {
            InitializeComponent();
            pw = panel1.Width;
            hided = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = .01;
            timer2.Interval = 5;
            timer2.Tick += IncreaseOpacity;
            timer2.Start();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        void IncreaseOpacity(object sender, EventArgs e)
        {
            if (this.Opacity <= 1)
            {
                this.Opacity += 0.01;
            }
            if (this.Opacity == 1)
                timer2.Stop();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.ForeColor = Color.White;
                panel5.Visible = false;
            }
            catch { }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox2.ForeColor = Color.White;
                panel7.Visible = false;
            }
            catch { }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = null;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Lime;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Блок UI для пользователя
            if (textBox1.Text == "")
            {
                textBox1.Text = "Введите логин";
            }

            if (textBox2.Text == "")
            {
                textBox2.Text = "Введите пароль";
            }

            if (textBox1.Text == "Введите логин")
            {
                panel5.Visible = true;
                textBox1.Focus();
                return;
            }

            if (textBox2.Text == "Введите пароль")
            {
                panel7.Visible = true;
                textBox2.Focus();
                return;
            }


            // Блок SQL запроса
            if (Attempt >= 3)
            {
                Attempt = 0;
                timer1.Enabled = true;
                label7.Visible = true;
                button1.Enabled = false;
                linkLabel2.Enabled = false;
                MessageBox.Show("Вы несколько раз ввели неверные данные, авторизация будет недоступна в течение некоторого времени.", "Предупреждение");
            }
            else
            {
                // Проверим введены ли значения в textBox
                if (textBox1.Text.Length >= 5 && textBox2.Text.Length >= 5)
                {
                    var Login = textBox1.Text;
                    var Password = textBox2.Text;
                    var Role = "0";
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable dataTable = new DataTable();
                    string querystring = $"select Логин, Пароль FROM Users WHERE Логин = '{Login}' and Пароль = '{Password}'";
                    SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());
                    adapter.SelectCommand = command;
                    adapter.Fill(dataTable);
                    // Если введены верные данные выполнить следующее...
                    if (dataTable.Rows.Count == 1)
                    {
                        SqlDataAdapter adapter2 = new SqlDataAdapter();
                        DataTable dataTable2 = new DataTable();
                        string querystring2 = $"select Логин, Пароль, [Тип пользователя] FROM Users WHERE Логин = '{Login}' and Пароль = '{Password}' and [Тип пользователя] = '{Role}'";
                        SqlCommand command2 = new SqlCommand(querystring2, dataBase.getConnection());
                        adapter2.SelectCommand = command2;
                        adapter2.Fill(dataTable2);
                        if (dataTable2.Rows.Count == 1)
                        {
                            MessageBox.Show($"Добро пожаловать {Login}", "Вы - Администратор");
                            this.Hide();
                            var Form_Admin_Selector = new Form_Admin_Selector();
                            Form_Admin_Selector.Closed += (s, args) => this.Close();
                            Form_Admin_Selector.Show();
                        }
                        else
                        {
                            MessageBox.Show($"Добро пожаловать {Login}", "Вы - Пользователь");
                            this.Hide();
                            var Form_User_Selector = new Form_User_Selector();
                            Form_User_Selector.Closed += (s, args) => this.Close();
                            Form_User_Selector.Show();
                        }
                    }
                    else
                    {
                        Attempt++;
                    }
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var FormRegistration = new FormRegistration(ThemeSet);
            FormRegistration.Closed += (s, args) => this.Close();
            FormRegistration.Show();
        }

        private void linkLabel1_Enter(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void linkLabel2_Enter(object sender, EventArgs e)
        {
            button1.Focus();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (CheckWrite == 0)
            {
                textBox2.PasswordChar = '\0';
                CheckWrite++;
            }
            else
            {
                textBox2.PasswordChar = '*';
                CheckWrite--;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Обратитесь к системному администратору.", "Сообщение");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // С каждой секундой выполняется следующее..
            CountTimer--;
            label7.Text = "Кнопка станет доступной через: " + CountTimer + " сек.";

            if (CountTimer <= 0)
            {
                timer1.Enabled = false;
                label7.Visible = false;
                button1.Enabled = true;
                linkLabel2.Enabled = true;
                CountTimer = 15;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012,0);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            this.Opacity = 0.5; 
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var Form_Admin_Selector = new Form_Admin_Selector();
            Form_Admin_Selector.Closed += (s, args) => this.Close();
            Form_Admin_Selector.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var Form_User_Selector = new Form_User_Selector();
            Form_User_Selector.Closed += (s, args) => this.Close();
            Form_User_Selector.Show();
        }
    }
} 
