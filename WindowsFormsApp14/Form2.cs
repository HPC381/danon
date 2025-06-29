using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void processorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.processorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.compDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "compDataSet.Processors". При необходимости она может быть перемещена или удалена.
            this.processorsTableAdapter.Fill(this.compDataSet.Processors);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Проверяет валидацию (например, Required поля)
                this.Validate();

                // 2. Применяет изменения из полей формы в DataTable
                this.processorsBindingSource.EndEdit();

                // 3. Отправляет ВСЕ изменения из DataSet в БД
                this.tableAdapterManager.UpdateAll(this.compDataSet);

                MessageBox.Show("Данные успешно сохранены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}");
            }

        }

        private void processorsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
