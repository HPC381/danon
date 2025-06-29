namespace WindowsFormsApp14
{
    partial class Form5
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label motherboardIdLabel;
            System.Windows.Forms.Label processorIdLabel;
            System.Windows.Forms.Label videoCardIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.compDataSet = new WindowsFormsApp14.compDataSet();
            this.compsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compsTableAdapter = new WindowsFormsApp14.compDataSetTableAdapters.CompsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp14.compDataSetTableAdapters.TableAdapterManager();
            this.videoCardsTableAdapter = new WindowsFormsApp14.compDataSetTableAdapters.VideoCardsTableAdapter();
            this.compsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.compsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.videoCardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compDataSet1 = new WindowsFormsApp14.compDataSet1();
            this.zakazBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakazTableAdapter = new WindowsFormsApp14.compDataSet1TableAdapters.ZakazTableAdapter();
            this.tableAdapterManager1 = new WindowsFormsApp14.compDataSet1TableAdapters.TableAdapterManager();
            this.motherboardsTableAdapter = new WindowsFormsApp14.compDataSet1TableAdapters.MotherboardsTableAdapter();
            this.zakazDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.motherboardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.processorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processorsTableAdapter = new WindowsFormsApp14.compDataSet1TableAdapters.ProcessorsTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.videoCardsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.videoCardsTableAdapter1 = new WindowsFormsApp14.compDataSet1TableAdapters.VideoCardsTableAdapter();
            nameLabel = new System.Windows.Forms.Label();
            motherboardIdLabel = new System.Windows.Forms.Label();
            processorIdLabel = new System.Windows.Forms.Label();
            videoCardIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.compDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compsBindingNavigator)).BeginInit();
            this.compsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoCardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motherboardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoCardsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(10, 44);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // motherboardIdLabel
            // 
            motherboardIdLabel.AutoSize = true;
            motherboardIdLabel.Location = new System.Drawing.Point(5, 70);
            motherboardIdLabel.Name = "motherboardIdLabel";
            motherboardIdLabel.Size = new System.Drawing.Size(82, 13);
            motherboardIdLabel.TabIndex = 3;
            motherboardIdLabel.Text = "Motherboard Id:";
            // 
            // processorIdLabel
            // 
            processorIdLabel.AutoSize = true;
            processorIdLabel.Location = new System.Drawing.Point(18, 96);
            processorIdLabel.Name = "processorIdLabel";
            processorIdLabel.Size = new System.Drawing.Size(69, 13);
            processorIdLabel.TabIndex = 5;
            processorIdLabel.Text = "Processor Id:";
            // 
            // videoCardIdLabel
            // 
            videoCardIdLabel.AutoSize = true;
            videoCardIdLabel.Location = new System.Drawing.Point(13, 122);
            videoCardIdLabel.Name = "videoCardIdLabel";
            videoCardIdLabel.Size = new System.Drawing.Size(74, 13);
            videoCardIdLabel.TabIndex = 7;
            videoCardIdLabel.Text = "Video Card Id:";
            // 
            // compDataSet
            // 
            this.compDataSet.DataSetName = "compDataSet";
            this.compDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compsBindingSource
            // 
            this.compsBindingSource.DataMember = "Comps";
            this.compsBindingSource.DataSource = this.compDataSet;
            // 
            // compsTableAdapter
            // 
            this.compsTableAdapter.ClearBeforeFill = true;
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
            // videoCardsTableAdapter
            // 
            this.videoCardsTableAdapter.ClearBeforeFill = true;
            // 
            // compsBindingNavigator
            // 
            this.compsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.compsBindingNavigator.BindingSource = this.compsBindingSource;
            this.compsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.compsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.compsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.compsBindingNavigatorSaveItem});
            this.compsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.compsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.compsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.compsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.compsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.compsBindingNavigator.Name = "compsBindingNavigator";
            this.compsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.compsBindingNavigator.Size = new System.Drawing.Size(794, 25);
            this.compsBindingNavigator.TabIndex = 0;
            this.compsBindingNavigator.Text = "bindingNavigator1";
            this.compsBindingNavigator.RefreshItems += new System.EventHandler(this.compsBindingNavigator_RefreshItems);
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
            // compsBindingNavigatorSaveItem
            // 
            this.compsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.compsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("compsBindingNavigatorSaveItem.Image")));
            this.compsBindingNavigatorSaveItem.Name = "compsBindingNavigatorSaveItem";
            this.compsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.compsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.compsBindingNavigatorSaveItem.Click += new System.EventHandler(this.compsBindingNavigatorSaveItem_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.compsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(54, 41);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // videoCardsBindingSource
            // 
            this.videoCardsBindingSource.DataMember = "VideoCards";
            this.videoCardsBindingSource.DataSource = this.compDataSet;
            // 
            // compDataSet1
            // 
            this.compDataSet1.DataSetName = "compDataSet1";
            this.compDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zakazBindingSource
            // 
            this.zakazBindingSource.DataMember = "Zakaz";
            this.zakazBindingSource.DataSource = this.compDataSet1;
            // 
            // zakazTableAdapter
            // 
            this.zakazTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CasesTableAdapter = null;
            this.tableAdapterManager1.CompsTableAdapter = null;
            this.tableAdapterManager1.MotherboardsTableAdapter = this.motherboardsTableAdapter;
            this.tableAdapterManager1.ProcessorsTableAdapter = null;
            this.tableAdapterManager1.PSUsTableAdapter = null;
            this.tableAdapterManager1.RAMTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp14.compDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VideoCardsTableAdapter = null;
            this.tableAdapterManager1.ZakazTableAdapter = this.zakazTableAdapter;
            // 
            // motherboardsTableAdapter
            // 
            this.motherboardsTableAdapter.ClearBeforeFill = true;
            // 
            // zakazDataGridView
            // 
            this.zakazDataGridView.AutoGenerateColumns = false;
            this.zakazDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zakazDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.zakazDataGridView.DataSource = this.zakazBindingSource;
            this.zakazDataGridView.Location = new System.Drawing.Point(238, 44);
            this.zakazDataGridView.Name = "zakazDataGridView";
            this.zakazDataGridView.Size = new System.Drawing.Size(544, 220);
            this.zakazDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdBuild";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdBuild";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MotherboardId";
            this.dataGridViewTextBoxColumn3.HeaderText = "MotherboardId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProcessorId";
            this.dataGridViewTextBoxColumn4.HeaderText = "ProcessorId";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "VideoCardId";
            this.dataGridViewTextBoxColumn5.HeaderText = "VideoCardId";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.motherboardsBindingSource, "IdMotherboard", true));
            this.comboBox1.DataSource = this.motherboardsBindingSource;
            this.comboBox1.DisplayMember = "Model";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "IdMotherboard";
            // 
            // motherboardsBindingSource
            // 
            this.motherboardsBindingSource.DataMember = "Motherboards";
            this.motherboardsBindingSource.DataSource = this.compDataSet1;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.processorsBindingSource, "IdProcessor", true));
            this.comboBox2.DataSource = this.processorsBindingSource;
            this.comboBox2.DisplayMember = "Model";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(93, 93);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.ValueMember = "IdProcessor";
            // 
            // processorsBindingSource
            // 
            this.processorsBindingSource.DataMember = "Processors";
            this.processorsBindingSource.DataSource = this.compDataSet1;
            // 
            // processorsTableAdapter
            // 
            this.processorsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.videoCardsBindingSource1, "IdVideoCard", true));
            this.comboBox3.DataSource = this.videoCardsBindingSource1;
            this.comboBox3.DisplayMember = "Model";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(93, 122);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 12;
            this.comboBox3.ValueMember = "IdVideoCard";
            // 
            // videoCardsBindingSource1
            // 
            this.videoCardsBindingSource1.DataMember = "VideoCards";
            this.videoCardsBindingSource1.DataSource = this.compDataSet1;
            // 
            // videoCardsTableAdapter1
            // 
            this.videoCardsTableAdapter1.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 432);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.zakazDataGridView);
            this.Controls.Add(videoCardIdLabel);
            this.Controls.Add(processorIdLabel);
            this.Controls.Add(motherboardIdLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.compsBindingNavigator);
            this.Name = "Form5";
            this.Text = "Сборка";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compsBindingNavigator)).EndInit();
            this.compsBindingNavigator.ResumeLayout(false);
            this.compsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoCardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motherboardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoCardsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private compDataSet compDataSet;
        private System.Windows.Forms.BindingSource compsBindingSource;
        private compDataSetTableAdapters.CompsTableAdapter compsTableAdapter;
        private compDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator compsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton compsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private compDataSetTableAdapters.VideoCardsTableAdapter videoCardsTableAdapter;
        private System.Windows.Forms.BindingSource videoCardsBindingSource;
        private compDataSet1 compDataSet1;
        private System.Windows.Forms.BindingSource zakazBindingSource;
        private compDataSet1TableAdapters.ZakazTableAdapter zakazTableAdapter;
        private compDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private compDataSet1TableAdapters.MotherboardsTableAdapter motherboardsTableAdapter;
        private System.Windows.Forms.DataGridView zakazDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource motherboardsBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource processorsBindingSource;
        private compDataSet1TableAdapters.ProcessorsTableAdapter processorsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource videoCardsBindingSource1;
        private compDataSet1TableAdapters.VideoCardsTableAdapter videoCardsTableAdapter1;
    }
}