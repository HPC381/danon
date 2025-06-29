namespace WindowsFormsApp14
{
    partial class Form3
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
            System.Windows.Forms.Label stampLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label memorySizeLabel;
            System.Windows.Forms.Label memoryTypeLabel;
            System.Windows.Forms.Label interfaceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.compDataSet = new WindowsFormsApp14.compDataSet();
            this.videoCardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videoCardsTableAdapter = new WindowsFormsApp14.compDataSetTableAdapters.VideoCardsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp14.compDataSetTableAdapters.TableAdapterManager();
            this.compsTableAdapter = new WindowsFormsApp14.compDataSetTableAdapters.CompsTableAdapter();
            this.videoCardsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.videoCardsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stampTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.memorySizeTextBox = new System.Windows.Forms.TextBox();
            this.memoryTypeTextBox = new System.Windows.Forms.TextBox();
            this.interfaceTextBox = new System.Windows.Forms.TextBox();
            this.compsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videoCardsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            stampLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            memorySizeLabel = new System.Windows.Forms.Label();
            memoryTypeLabel = new System.Windows.Forms.Label();
            interfaceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.compDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoCardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoCardsBindingNavigator)).BeginInit();
            this.videoCardsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoCardsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stampLabel
            // 
            stampLabel.AutoSize = true;
            stampLabel.Location = new System.Drawing.Point(5, 43);
            stampLabel.Name = "stampLabel";
            stampLabel.Size = new System.Drawing.Size(40, 13);
            stampLabel.TabIndex = 1;
            stampLabel.Text = "Stamp:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(6, 69);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 3;
            modelLabel.Text = "Model:";
            // 
            // memorySizeLabel
            // 
            memorySizeLabel.AutoSize = true;
            memorySizeLabel.Location = new System.Drawing.Point(8, 95);
            memorySizeLabel.Name = "memorySizeLabel";
            memorySizeLabel.Size = new System.Drawing.Size(70, 13);
            memorySizeLabel.TabIndex = 5;
            memorySizeLabel.Text = "Memory Size:";
            // 
            // memoryTypeLabel
            // 
            memoryTypeLabel.AutoSize = true;
            memoryTypeLabel.Location = new System.Drawing.Point(4, 121);
            memoryTypeLabel.Name = "memoryTypeLabel";
            memoryTypeLabel.Size = new System.Drawing.Size(74, 13);
            memoryTypeLabel.TabIndex = 7;
            memoryTypeLabel.Text = "Memory Type:";
            // 
            // interfaceLabel
            // 
            interfaceLabel.AutoSize = true;
            interfaceLabel.Location = new System.Drawing.Point(26, 147);
            interfaceLabel.Name = "interfaceLabel";
            interfaceLabel.Size = new System.Drawing.Size(52, 13);
            interfaceLabel.TabIndex = 9;
            interfaceLabel.Text = "Interface:";
            // 
            // compDataSet
            // 
            this.compDataSet.DataSetName = "compDataSet";
            this.compDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // videoCardsBindingSource
            // 
            this.videoCardsBindingSource.DataMember = "VideoCards";
            this.videoCardsBindingSource.DataSource = this.compDataSet;
            // 
            // videoCardsTableAdapter
            // 
            this.videoCardsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CasesTableAdapter = null;
            this.tableAdapterManager.CompsTableAdapter = this.compsTableAdapter;
            this.tableAdapterManager.MotherboardsTableAdapter = null;
            this.tableAdapterManager.ProcessorsTableAdapter = null;
            this.tableAdapterManager.PSUsTableAdapter = null;
            this.tableAdapterManager.RAMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp14.compDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VideoCardsTableAdapter = this.videoCardsTableAdapter;
            // 
            // compsTableAdapter
            // 
            this.compsTableAdapter.ClearBeforeFill = true;
            // 
            // videoCardsBindingNavigator
            // 
            this.videoCardsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.videoCardsBindingNavigator.BindingSource = this.videoCardsBindingSource;
            this.videoCardsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.videoCardsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.videoCardsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.videoCardsBindingNavigatorSaveItem});
            this.videoCardsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.videoCardsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.videoCardsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.videoCardsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.videoCardsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.videoCardsBindingNavigator.Name = "videoCardsBindingNavigator";
            this.videoCardsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.videoCardsBindingNavigator.Size = new System.Drawing.Size(823, 25);
            this.videoCardsBindingNavigator.TabIndex = 0;
            this.videoCardsBindingNavigator.Text = "bindingNavigator1";
            this.videoCardsBindingNavigator.RefreshItems += new System.EventHandler(this.videoCardsBindingNavigator_RefreshItems);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // videoCardsBindingNavigatorSaveItem
            // 
            this.videoCardsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.videoCardsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("videoCardsBindingNavigatorSaveItem.Image")));
            this.videoCardsBindingNavigatorSaveItem.Name = "videoCardsBindingNavigatorSaveItem";
            this.videoCardsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.videoCardsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.videoCardsBindingNavigatorSaveItem.Click += new System.EventHandler(this.videoCardsBindingNavigatorSaveItem_Click);
            // 
            // stampTextBox
            // 
            this.stampTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.videoCardsBindingSource, "Stamp", true));
            this.stampTextBox.Location = new System.Drawing.Point(51, 40);
            this.stampTextBox.Name = "stampTextBox";
            this.stampTextBox.Size = new System.Drawing.Size(100, 20);
            this.stampTextBox.TabIndex = 2;
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.videoCardsBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(51, 66);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 4;
            // 
            // memorySizeTextBox
            // 
            this.memorySizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.videoCardsBindingSource, "MemorySize", true));
            this.memorySizeTextBox.Location = new System.Drawing.Point(84, 92);
            this.memorySizeTextBox.Name = "memorySizeTextBox";
            this.memorySizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.memorySizeTextBox.TabIndex = 6;
            // 
            // memoryTypeTextBox
            // 
            this.memoryTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.videoCardsBindingSource, "MemoryType", true));
            this.memoryTypeTextBox.Location = new System.Drawing.Point(84, 118);
            this.memoryTypeTextBox.Name = "memoryTypeTextBox";
            this.memoryTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.memoryTypeTextBox.TabIndex = 8;
            // 
            // interfaceTextBox
            // 
            this.interfaceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.videoCardsBindingSource, "Interface", true));
            this.interfaceTextBox.Location = new System.Drawing.Point(84, 144);
            this.interfaceTextBox.Name = "interfaceTextBox";
            this.interfaceTextBox.Size = new System.Drawing.Size(100, 20);
            this.interfaceTextBox.TabIndex = 10;
            // 
            // compsBindingSource
            // 
            this.compsBindingSource.DataMember = "Comps";
            this.compsBindingSource.DataSource = this.compDataSet;
            // 
            // videoCardsDataGridView
            // 
            this.videoCardsDataGridView.AutoGenerateColumns = false;
            this.videoCardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.videoCardsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.videoCardsDataGridView.DataSource = this.videoCardsBindingSource;
            this.videoCardsDataGridView.Location = new System.Drawing.Point(262, 40);
            this.videoCardsDataGridView.Name = "videoCardsDataGridView";
            this.videoCardsDataGridView.Size = new System.Drawing.Size(546, 220);
            this.videoCardsDataGridView.TabIndex = 14;
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MemorySize";
            this.dataGridViewTextBoxColumn4.HeaderText = "MemorySize";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MemoryType";
            this.dataGridViewTextBoxColumn5.HeaderText = "MemoryType";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Interface";
            this.dataGridViewTextBoxColumn6.HeaderText = "Interface";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 277);
            this.Controls.Add(this.videoCardsDataGridView);
            this.Controls.Add(interfaceLabel);
            this.Controls.Add(this.interfaceTextBox);
            this.Controls.Add(memoryTypeLabel);
            this.Controls.Add(this.memoryTypeTextBox);
            this.Controls.Add(memorySizeLabel);
            this.Controls.Add(this.memorySizeTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(stampLabel);
            this.Controls.Add(this.stampTextBox);
            this.Controls.Add(this.videoCardsBindingNavigator);
            this.Name = "Form3";
            this.Text = "Видеокарта";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoCardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoCardsBindingNavigator)).EndInit();
            this.videoCardsBindingNavigator.ResumeLayout(false);
            this.videoCardsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoCardsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private compDataSet compDataSet;
        private System.Windows.Forms.BindingSource videoCardsBindingSource;
        private compDataSetTableAdapters.VideoCardsTableAdapter videoCardsTableAdapter;
        private compDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator videoCardsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton videoCardsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox stampTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox memorySizeTextBox;
        private System.Windows.Forms.TextBox memoryTypeTextBox;
        private System.Windows.Forms.TextBox interfaceTextBox;
        private compDataSetTableAdapters.CompsTableAdapter compsTableAdapter;
        private System.Windows.Forms.BindingSource compsBindingSource;
        private System.Windows.Forms.DataGridView videoCardsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}