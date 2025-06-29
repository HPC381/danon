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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void videoCardsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.videoCardsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.compDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "compDataSet.VideoCards". При необходимости она может быть перемещена или удалена.
            this.videoCardsTableAdapter.Fill(this.compDataSet.VideoCards);

        }

        private void videoCardsBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
