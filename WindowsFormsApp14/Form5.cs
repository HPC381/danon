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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void compsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zakazBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.compDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "compDataSet1.VideoCards". При необходимости она может быть перемещена или удалена.
            this.videoCardsTableAdapter1.Fill(this.compDataSet1.VideoCards);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "compDataSet1.Processors". При необходимости она может быть перемещена или удалена.
            this.processorsTableAdapter.Fill(this.compDataSet1.Processors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "compDataSet1.Motherboards". При необходимости она может быть перемещена или удалена.
            this.motherboardsTableAdapter.Fill(this.compDataSet1.Motherboards);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "compDataSet1.Zakaz". При необходимости она может быть перемещена или удалена.
            this.zakazTableAdapter.Fill(this.compDataSet1.Zakaz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "compDataSet.VideoCards". При необходимости она может быть перемещена или удалена.
            this.videoCardsTableAdapter.Fill(this.compDataSet.VideoCards);
        }

        private void compsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
