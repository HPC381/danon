﻿using System;
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
    public partial class mother : Form
    {
        public mother()
        {
            InitializeComponent();
        }

        private void motherboardsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.motherboardsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.compDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "compDataSet.Motherboards". При необходимости она может быть перемещена или удалена.
            this.motherboardsTableAdapter.Fill(this.compDataSet.Motherboards);

        }
    }
}
