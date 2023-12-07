namespace Modern_UI_Material_Sklad
{
    partial class Tab_Selector_Loader
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tab_Selector_Loader));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.frame_DB_Tovar1 = new Modern_UI_Material_Sklad.Frame_DB_Tovar();
            this.frame_DB_Sklad1 = new Modern_UI_Material_Sklad.Frame_DB_Sklad();
            this.frame_DB_Sklad_Parts1 = new Modern_UI_Material_Sklad.Frame_DB_Sklad_Parts();
            this.frame_DB_List1 = new Modern_UI_Material_Sklad.Frame_DB_List();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 354);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(408, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "4 -";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "3 -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "2 -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "1 -";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(9, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Доступные таблицы:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(459, 88);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(187, 44);
            this.button4.TabIndex = 20;
            this.button4.Text = "Отчет";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(59, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 44);
            this.button3.TabIndex = 19;
            this.button3.Text = "Склад";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(59, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 44);
            this.button2.TabIndex = 18;
            this.button2.Text = "Отдел склада";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(59, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 44);
            this.button1.TabIndex = 17;
            this.button1.Text = "Товар";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frame_DB_Tovar1
            // 
            this.frame_DB_Tovar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.frame_DB_Tovar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frame_DB_Tovar1.Location = new System.Drawing.Point(0, 0);
            this.frame_DB_Tovar1.Name = "frame_DB_Tovar1";
            this.frame_DB_Tovar1.Size = new System.Drawing.Size(698, 412);
            this.frame_DB_Tovar1.TabIndex = 31;
            this.frame_DB_Tovar1.Visible = false;
            // 
            // frame_DB_Sklad1
            // 
            this.frame_DB_Sklad1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.frame_DB_Sklad1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frame_DB_Sklad1.Location = new System.Drawing.Point(0, 0);
            this.frame_DB_Sklad1.Name = "frame_DB_Sklad1";
            this.frame_DB_Sklad1.Size = new System.Drawing.Size(698, 412);
            this.frame_DB_Sklad1.TabIndex = 32;
            this.frame_DB_Sklad1.Visible = false;
            // 
            // frame_DB_Sklad_Parts1
            // 
            this.frame_DB_Sklad_Parts1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.frame_DB_Sklad_Parts1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frame_DB_Sklad_Parts1.Location = new System.Drawing.Point(0, 0);
            this.frame_DB_Sklad_Parts1.Name = "frame_DB_Sklad_Parts1";
            this.frame_DB_Sklad_Parts1.Size = new System.Drawing.Size(698, 412);
            this.frame_DB_Sklad_Parts1.TabIndex = 33;
            this.frame_DB_Sklad_Parts1.Visible = false;
            // 
            // frame_DB_List1
            // 
            this.frame_DB_List1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.frame_DB_List1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frame_DB_List1.Location = new System.Drawing.Point(0, 0);
            this.frame_DB_List1.Name = "frame_DB_List1";
            this.frame_DB_List1.Size = new System.Drawing.Size(698, 412);
            this.frame_DB_List1.TabIndex = 34;
            this.frame_DB_List1.Visible = false;
            // 
            // Tab_Selector_Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.frame_DB_List1);
            this.Controls.Add(this.frame_DB_Sklad_Parts1);
            this.Controls.Add(this.frame_DB_Sklad1);
            this.Controls.Add(this.frame_DB_Tovar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Tab_Selector_Loader";
            this.Size = new System.Drawing.Size(698, 412);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Frame_DB_Tovar frame_DB_Tovar1;
        private Frame_DB_Sklad frame_DB_Sklad1;
        private Frame_DB_Sklad_Parts frame_DB_Sklad_Parts1;
        private Frame_DB_List frame_DB_List1;
    }
}
