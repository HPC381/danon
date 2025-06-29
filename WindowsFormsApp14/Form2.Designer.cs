namespace WindowsFormsApp14
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.Label stampLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label socketLabel;
            System.Windows.Forms.Label coresLabel;
            System.Windows.Forms.Label threadsLabel;
            System.Windows.Forms.Label intGraphLabel;
            this.compDataSet = new WindowsFormsApp14.compDataSet();
            this.processorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.processorsTableAdapter = new WindowsFormsApp14.compDataSetTableAdapters.ProcessorsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp14.compDataSetTableAdapters.TableAdapterManager();
            this.processorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.processorsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stampTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.socketTextBox = new System.Windows.Forms.TextBox();
            this.coresTextBox = new System.Windows.Forms.TextBox();
            this.threadsTextBox = new System.Windows.Forms.TextBox();
            this.intGraphCheckBox = new System.Windows.Forms.CheckBox();
            this.processorsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            stampLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            socketLabel = new System.Windows.Forms.Label();
            coresLabel = new System.Windows.Forms.Label();
            threadsLabel = new System.Windows.Forms.Label();
            intGraphLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.compDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorsBindingNavigator)).BeginInit();
            this.processorsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processorsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // compDataSet
            // 
            this.compDataSet.DataSetName = "compDataSet";
            this.compDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // processorsBindingSource
            // 
            this.processorsBindingSource.DataMember = "Processors";
            this.processorsBindingSource.DataSource = this.compDataSet;
            // 
            // processorsTableAdapter
            // 
            this.processorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CasesTableAdapter = null;
            this.tableAdapterManager.CompsTableAdapter = null;
            this.tableAdapterManager.MotherboardsTableAdapter = null;
            this.tableAdapterManager.ProcessorsTableAdapter = this.processorsTableAdapter;
            this.tableAdapterManager.PSUsTableAdapter = null;
            this.tableAdapterManager.RAMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp14.compDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VideoCardsTableAdapter = null;
            // 
            // processorsBindingNavigator
            // 
            this.processorsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.processorsBindingNavigator.BindingSource = this.processorsBindingSource;
            this.processorsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.processorsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.processorsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.processorsBindingNavigatorSaveItem});
            this.processorsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.processorsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.processorsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.processorsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.processorsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.processorsBindingNavigator.Name = "processorsBindingNavigator";
            this.processorsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.processorsBindingNavigator.Size = new System.Drawing.Size(977, 25);
            this.processorsBindingNavigator.TabIndex = 0;
            this.processorsBindingNavigator.Text = "bindingNavigator1";
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
            // processorsBindingNavigatorSaveItem
            // 
            this.processorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.processorsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("processorsBindingNavigatorSaveItem.Image")));
            this.processorsBindingNavigatorSaveItem.Name = "processorsBindingNavigatorSaveItem";
            this.processorsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.processorsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.processorsBindingNavigatorSaveItem.Click += new System.EventHandler(this.processorsBindingNavigatorSaveItem_Click);
            // 
            // stampLabel
            // 
            stampLabel.AutoSize = true;
            stampLabel.Location = new System.Drawing.Point(12, 41);
            stampLabel.Name = "stampLabel";
            stampLabel.Size = new System.Drawing.Size(40, 13);
            stampLabel.TabIndex = 1;
            stampLabel.Text = "Stamp:";
            // 
            // stampTextBox
            // 
            this.stampTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.processorsBindingSource, "Stamp", true));
            this.stampTextBox.Location = new System.Drawing.Point(58, 38);
            this.stampTextBox.Name = "stampTextBox";
            this.stampTextBox.Size = new System.Drawing.Size(100, 20);
            this.stampTextBox.TabIndex = 2;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(13, 67);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 3;
            modelLabel.Text = "Model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.processorsBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(58, 64);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(100, 20);
            this.modelTextBox.TabIndex = 4;
            // 
            // socketLabel
            // 
            socketLabel.AutoSize = true;
            socketLabel.Location = new System.Drawing.Point(8, 93);
            socketLabel.Name = "socketLabel";
            socketLabel.Size = new System.Drawing.Size(44, 13);
            socketLabel.TabIndex = 5;
            socketLabel.Text = "Socket:";
            // 
            // socketTextBox
            // 
            this.socketTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.processorsBindingSource, "Socket", true));
            this.socketTextBox.Location = new System.Drawing.Point(58, 90);
            this.socketTextBox.Name = "socketTextBox";
            this.socketTextBox.Size = new System.Drawing.Size(100, 20);
            this.socketTextBox.TabIndex = 6;
            // 
            // coresLabel
            // 
            coresLabel.AutoSize = true;
            coresLabel.Location = new System.Drawing.Point(15, 119);
            coresLabel.Name = "coresLabel";
            coresLabel.Size = new System.Drawing.Size(37, 13);
            coresLabel.TabIndex = 7;
            coresLabel.Text = "Cores:";
            // 
            // coresTextBox
            // 
            this.coresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.processorsBindingSource, "Cores", true));
            this.coresTextBox.Location = new System.Drawing.Point(58, 116);
            this.coresTextBox.Name = "coresTextBox";
            this.coresTextBox.Size = new System.Drawing.Size(100, 20);
            this.coresTextBox.TabIndex = 8;
            // 
            // threadsLabel
            // 
            threadsLabel.AutoSize = true;
            threadsLabel.Location = new System.Drawing.Point(3, 145);
            threadsLabel.Name = "threadsLabel";
            threadsLabel.Size = new System.Drawing.Size(49, 13);
            threadsLabel.TabIndex = 9;
            threadsLabel.Text = "Threads:";
            // 
            // threadsTextBox
            // 
            this.threadsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.processorsBindingSource, "Threads", true));
            this.threadsTextBox.Location = new System.Drawing.Point(58, 142);
            this.threadsTextBox.Name = "threadsTextBox";
            this.threadsTextBox.Size = new System.Drawing.Size(100, 20);
            this.threadsTextBox.TabIndex = 10;
            // 
            // intGraphLabel
            // 
            intGraphLabel.AutoSize = true;
            intGraphLabel.Location = new System.Drawing.Point(12, 173);
            intGraphLabel.Name = "intGraphLabel";
            intGraphLabel.Size = new System.Drawing.Size(54, 13);
            intGraphLabel.TabIndex = 11;
            intGraphLabel.Text = "Int Graph:";
            // 
            // intGraphCheckBox
            // 
            this.intGraphCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.processorsBindingSource, "IntGraph", true));
            this.intGraphCheckBox.Location = new System.Drawing.Point(72, 168);
            this.intGraphCheckBox.Name = "intGraphCheckBox";
            this.intGraphCheckBox.Size = new System.Drawing.Size(104, 24);
            this.intGraphCheckBox.TabIndex = 12;
            this.intGraphCheckBox.Text = "checkBox1";
            this.intGraphCheckBox.UseVisualStyleBackColor = true;
            // 
            // processorsDataGridView
            // 
            this.processorsDataGridView.AutoGenerateColumns = false;
            this.processorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.processorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewCheckBoxColumn1});
            this.processorsDataGridView.DataSource = this.processorsBindingSource;
            this.processorsDataGridView.Location = new System.Drawing.Point(299, 38);
            this.processorsDataGridView.Name = "processorsDataGridView";
            this.processorsDataGridView.Size = new System.Drawing.Size(644, 220);
            this.processorsDataGridView.TabIndex = 14;
            this.processorsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.processorsDataGridView_CellContentClick);
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
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cores";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cores";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Threads";
            this.dataGridViewTextBoxColumn6.HeaderText = "Threads";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IntGraph";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IntGraph";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 283);
            this.Controls.Add(this.processorsDataGridView);
            this.Controls.Add(intGraphLabel);
            this.Controls.Add(this.intGraphCheckBox);
            this.Controls.Add(threadsLabel);
            this.Controls.Add(this.threadsTextBox);
            this.Controls.Add(coresLabel);
            this.Controls.Add(this.coresTextBox);
            this.Controls.Add(socketLabel);
            this.Controls.Add(this.socketTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(stampLabel);
            this.Controls.Add(this.stampTextBox);
            this.Controls.Add(this.processorsBindingNavigator);
            this.Name = "Form2";
            this.Text = "Процессор";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorsBindingNavigator)).EndInit();
            this.processorsBindingNavigator.ResumeLayout(false);
            this.processorsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processorsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private compDataSet compDataSet;
        private System.Windows.Forms.BindingSource processorsBindingSource;
        private compDataSetTableAdapters.ProcessorsTableAdapter processorsTableAdapter;
        private compDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator processorsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton processorsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox stampTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox socketTextBox;
        private System.Windows.Forms.TextBox coresTextBox;
        private System.Windows.Forms.TextBox threadsTextBox;
        private System.Windows.Forms.CheckBox intGraphCheckBox;
        private System.Windows.Forms.DataGridView processorsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}