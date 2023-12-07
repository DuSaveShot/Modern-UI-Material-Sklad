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
    public partial class Frame_DB_Sklad_Parts : UserControl
    {
        int RowsRemovedCount = 0;
        int RowsAddedCount = 0;
        int RowsChangedCount = 0;
        int SerchRowsCount = 0;

        public Frame_DB_Sklad_Parts()
        {
            InitializeComponent();
        }

        private void Frame_DB_Sklad_Parts_Load(object sender, EventArgs e)
        {
            //this.material_TABLETableAdapter.Fill(this.kurs_3_Material_SkladDataSet.Material_TABLE);
            RowsChangedCount = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Чтобы сохранить изменения, нажмите клавишу - Esc", "Сообщение");
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            RowsChangedCount++;
            if (RowsRemovedCount > 0)
            {
                RowsChangedCount -= RowsRemovedCount;
            }
            if (RowsAddedCount > 0)
            {
                RowsChangedCount -= RowsAddedCount;
            }
            if (RowsRemovedCount < 0)
            {
                RowsChangedCount = 0;
            }
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            RowsAddedCount++;
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            RowsRemovedCount++;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (string.IsNullOrEmpty(textBox1.Text))
            //    materialTABLEBindingSource.Filter = string.Empty;
            //else
            //    materialTABLEBindingSource.Filter = string.Format("Наименование LIKE '%{0}%'", textBox1.Text);

            //SerchRowsCount = dataGridView1.Rows.Count - 1;
            //label1.Text = "Сопадений: " + SerchRowsCount;
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                //    materialTABLEBindingSource.EndEdit();
                //    material_TABLETableAdapter.Update(kurs_3_Material_SkladDataSet.Material_TABLE);
                //    MessageBox.Show("Кол-во добавленных новых строк: " + RowsAddedCount + "\n" +
                //        "Кол-во удаленных строк: " + RowsRemovedCount + "\n" +
                //        "Кол-во измененных ячеек: " + RowsChangedCount + "\n");
                //    RowsAddedCount = 0;
                //    RowsChangedCount = 0;
                //    RowsRemovedCount = 0;
            }
        }
    }
}
