namespace WindowsFormsApp14
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label stampLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label socketLabel;
            this.compDataSet = new WindowsFormsApp14.compDataSet();
            this.motherboardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motherboardsTableAdapter = new WindowsFormsApp14.compDataSetTableAdapters.MotherboardsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp14.compDataSetTableAdapters.TableAdapterManager();
            this.motherboardsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.motherboardsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stampTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.socketTextBox = new System.Windows.Forms.TextBox();
            this.motherboardsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            stampLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            socketLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.compDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motherboardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motherboardsBindingNavigator)).BeginInit();
            this.motherboardsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motherboardsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // compDataSet
            // 
            this.compDataSet.DataSetName = "compDataSet";
            this.compDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // motherboardsBindingSource
            // 
            this.motherboardsBindingSource.DataMember = "Motherboards";
            this.motherboardsBindingSource.DataSource = this.compDataSet;
            // 
            // motherboardsTableAdapter
            // 
            this.motherboardsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CasesTableAdapter = null;
            this.tableAdapterManager.CompsTableAdapter = null;
            this.tableAdapterManager.MotherboardsTableAdapter = this.motherboardsTableAdapter;
            this.tableAdapterManager.ProcessorsTableAdapter = null;
            this.tableAdapterManager.PSUsTableAdapter = null;
            this.tableAdapterManager.RAMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp14.compDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VideoCardsTableAdapter = null;
            // 
            // motherboardsBindingNavigator
            // 
            this.motherboardsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.motherboardsBindingNavigator.BindingSource = this.motherboardsBindingSource;
            this.motherboardsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.motherboardsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.motherboardsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.motherboardsBindingNavigatorSaveItem});
            this.motherboardsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.motherboardsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.motherboardsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.motherboardsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.motherboardsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.motherboardsBindingNavigator.Name = "motherboardsBindingNavigator";
            this.motherboardsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.motherboardsBindingNavigator.Size = new System.Drawing.Size(705, 25);
            this.motherboardsBindingNavigator.TabIndex = 0;
            this.motherboardsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // motherboardsBindingNavigatorSaveItem
            // 
            this.motherboardsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.motherboardsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("motherboardsBindingNavigatorSaveItem.Image")));
            this.motherboardsBindingNavigatorSaveItem.Name = "motherboardsBindingNavigatorSaveItem";
            this.motherboardsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.motherboardsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.motherboardsBindingNavigatorSaveItem.Click += new System.EventHandler(this.motherboardsBindingNavigatorSaveItem_Click);
            // 
            // stampLabel
            // 
            stampLabel.AutoSize = true;
            stampLabel.Location = new System.Drawing.Point(10, 31);
            stampLabel.Name = "stampLabel";
            stampLabel.Size = new System.Drawing.Size(40, 13);
            stampLabel.TabIndex = 1;
            stampLabel.Text = "Stamp:";
            // 
            // stampTextBox
            // 
            this.stampTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motherboardsBindingSource, "Stamp", true));
            this.stampTextBox.Location = new System.Drawing.Point(56, 28);
            this.stampTextBox.Name = "stampTextBox";
            this.stampTextBox.Size = new System.Drawing.Size(100, 20);
            this.stampTextBox.TabIndex = 2;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(11, 57);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 3;
            modelLabel.Text = "Model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motherboardsBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(56, 54);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 4;
            // 
            // socketLabel
            // 
            socketLabel.AutoSize = true;
            socketLabel.Location = new System.Drawing.Point(6, 83);
            socketLabel.Name = "socketLabel";
            socketLabel.Size = new System.Drawing.Size(44, 13);
            socketLabel.TabIndex = 5;
            socketLabel.Text = "Socket:";
            // 
            // socketTextBox
            // 
            this.socketTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motherboardsBindingSource, "Socket", true));
            this.socketTextBox.Location = new System.Drawing.Point(56, 80);
            this.socketTextBox.Name = "socketTextBox";
            this.socketTextBox.Size = new System.Drawing.Size(100, 20);
            this.socketTextBox.TabIndex = 6;
            // 
            // motherboardsDataGridView
            // 
            this.motherboardsDataGridView.AutoGenerateColumns = false;
            this.motherboardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.motherboardsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.motherboardsDataGridView.DataSource = this.motherboardsBindingSource;
            this.motherboardsDataGridView.Location = new System.Drawing.Point(187, 31);
            this.motherboardsDataGridView.Name = "motherboardsDataGridView";
            this.motherboardsDataGridView.Size = new System.Drawing.Size(444, 220);
            this.motherboardsDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Stamp";
            this.dataGridViewTextBoxColumn2.HeaderText = "Stamp";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Model";
            this.dataGridViewTextBoxColumn3.HeaderText = "Model";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Socket";
            this.dataGridViewTextBoxColumn4.HeaderText = "Socket";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 264);
            this.Controls.Add(this.motherboardsDataGridView);
            this.Controls.Add(socketLabel);
            this.Controls.Add(this.socketTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(stampLabel);
            this.Controls.Add(this.stampTextBox);
            this.Controls.Add(this.motherboardsBindingNavigator);
            this.Name = "Form4";
            this.Text = "Мат плата";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motherboardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motherboardsBindingNavigator)).EndInit();
            this.motherboardsBindingNavigator.ResumeLayout(false);
            this.motherboardsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motherboardsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private compDataSet compDataSet;
        private System.Windows.Forms.BindingSource motherboardsBindingSource;
        private compDataSetTableAdapters.MotherboardsTableAdapter motherboardsTableAdapter;
        private compDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator motherboardsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton motherboardsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox stampTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox socketTextBox;
        private System.Windows.Forms.DataGridView motherboardsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}