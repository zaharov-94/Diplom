namespace Diplom
{
    partial class formSupplyEx
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
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label clientIDLabel;
            System.Windows.Forms.Label employeeIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSupplyEx));
            this.SupplyIDLabel = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.diplomDataSet = new Diplom.DiplomDataSet();
            this.suppliesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suppliesTableAdapter = new Diplom.DiplomDataSetTableAdapters.SuppliesTableAdapter();
            this.tableAdapterManager = new Diplom.DiplomDataSetTableAdapters.TableAdapterManager();
            this.supplyIDTextBox = new System.Windows.Forms.TextBox();
            this.employeeIDComboBox = new System.Windows.Forms.ComboBox();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.suppliesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.suppliesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.providerIDComboBox = new System.Windows.Forms.ComboBox();
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providersTableAdapter = new Diplom.DiplomDataSetTableAdapters.ProvidersTableAdapter();
            this.employeesTableAdapter = new Diplom.DiplomDataSetTableAdapters.EmployeesTableAdapter();
            this.supplyProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplyProductsTableAdapter = new Diplom.DiplomDataSetTableAdapters.SupplyProductsTableAdapter();
            this.supplyProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dateLabel = new System.Windows.Forms.Label();
            clientIDLabel = new System.Windows.Forms.Label();
            employeeIDLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingNavigator)).BeginInit();
            this.suppliesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(95, 63);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(36, 13);
            dateLabel.TabIndex = 5;
            dateLabel.Text = "Дата:";
            // 
            // clientIDLabel
            // 
            clientIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            clientIDLabel.AutoSize = true;
            clientIDLabel.Location = new System.Drawing.Point(63, 86);
            clientIDLabel.Name = "clientIDLabel";
            clientIDLabel.Size = new System.Drawing.Size(68, 13);
            clientIDLabel.TabIndex = 7;
            clientIDLabel.Text = "Поставщик:";
            // 
            // employeeIDLabel
            // 
            employeeIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            employeeIDLabel.AutoSize = true;
            employeeIDLabel.Location = new System.Drawing.Point(68, 113);
            employeeIDLabel.Name = "employeeIDLabel";
            employeeIDLabel.Size = new System.Drawing.Size(63, 13);
            employeeIDLabel.TabIndex = 12;
            employeeIDLabel.Text = "Менеджер:";
            // 
            // SupplyIDLabel
            // 
            this.SupplyIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SupplyIDLabel.AutoSize = true;
            this.SupplyIDLabel.Location = new System.Drawing.Point(51, 36);
            this.SupplyIDLabel.Name = "SupplyIDLabel";
            this.SupplyIDLabel.Size = new System.Drawing.Size(80, 13);
            this.SupplyIDLabel.TabIndex = 1;
            this.SupplyIDLabel.Text = "Накладная №:";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(113, 4);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(13, 13);
            this.labelTotalPrice.TabIndex = 10;
            this.labelTotalPrice.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Итоговая цена";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelTotalPrice);
            this.panel1.Location = new System.Drawing.Point(340, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 22);
            this.panel1.TabIndex = 12;
            // 
            // diplomDataSet
            // 
            this.diplomDataSet.DataSetName = "DiplomDataSet";
            this.diplomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // suppliesBindingSource
            // 
            this.suppliesBindingSource.DataMember = "Supplies";
            this.suppliesBindingSource.DataSource = this.diplomDataSet;
            // 
            // suppliesTableAdapter
            // 
            this.suppliesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.OrderProductsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.ProvidersTableAdapter = null;
            this.tableAdapterManager.SuppliesTableAdapter = this.suppliesTableAdapter;
            this.tableAdapterManager.SupplyProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Diplom.DiplomDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // supplyIDTextBox
            // 
            this.supplyIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.supplyIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliesBindingSource, "supplyID", true));
            this.supplyIDTextBox.Enabled = false;
            this.supplyIDTextBox.Location = new System.Drawing.Point(137, 33);
            this.supplyIDTextBox.Name = "supplyIDTextBox";
            this.supplyIDTextBox.Size = new System.Drawing.Size(209, 20);
            this.supplyIDTextBox.TabIndex = 15;
            this.supplyIDTextBox.TextChanged += new System.EventHandler(this.SupplyIDTextBox_TextChanged);
            // 
            // employeeIDComboBox
            // 
            this.employeeIDComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliesBindingSource, "employeeID", true));
            this.employeeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.suppliesBindingSource, "employeeID", true));
            this.employeeIDComboBox.DataSource = this.employeesBindingSource;
            this.employeeIDComboBox.DisplayMember = "lastName";
            this.employeeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.employeeIDComboBox.FormattingEnabled = true;
            this.employeeIDComboBox.Location = new System.Drawing.Point(137, 110);
            this.employeeIDComboBox.Name = "employeeIDComboBox";
            this.employeeIDComboBox.Size = new System.Drawing.Size(209, 21);
            this.employeeIDComboBox.TabIndex = 16;
            this.employeeIDComboBox.ValueMember = "employeeID";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.diplomDataSet;
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // suppliesBindingNavigatorSaveItem
            // 
            this.suppliesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.suppliesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("suppliesBindingNavigatorSaveItem.Image")));
            this.suppliesBindingNavigatorSaveItem.Name = "suppliesBindingNavigatorSaveItem";
            this.suppliesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.suppliesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.suppliesBindingNavigatorSaveItem.Click += new System.EventHandler(this.suppliesBindingNavigatorSaveItem_Click);
            // 
            // suppliesBindingNavigator
            // 
            this.suppliesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.suppliesBindingNavigator.BindingSource = this.suppliesBindingSource;
            this.suppliesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.suppliesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.suppliesBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.suppliesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.suppliesBindingNavigatorSaveItem});
            this.suppliesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.suppliesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.suppliesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.suppliesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.suppliesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.suppliesBindingNavigator.Name = "suppliesBindingNavigator";
            this.suppliesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.suppliesBindingNavigator.Size = new System.Drawing.Size(527, 25);
            this.suppliesBindingNavigator.TabIndex = 14;
            this.suppliesBindingNavigator.Text = "bindingNavigator1";
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.suppliesBindingSource, "date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(137, 57);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(209, 20);
            this.dateDateTimePicker.TabIndex = 17;
            // 
            // providerIDComboBox
            // 
            this.providerIDComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.providerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.suppliesBindingSource, "providerID", true));
            this.providerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.suppliesBindingSource, "providerID", true));
            this.providerIDComboBox.DataSource = this.providersBindingSource;
            this.providerIDComboBox.DisplayMember = "name";
            this.providerIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.providerIDComboBox.FormattingEnabled = true;
            this.providerIDComboBox.Location = new System.Drawing.Point(137, 83);
            this.providerIDComboBox.Name = "providerIDComboBox";
            this.providerIDComboBox.Size = new System.Drawing.Size(209, 21);
            this.providerIDComboBox.TabIndex = 18;
            this.providerIDComboBox.ValueMember = "providerID";
            // 
            // providersBindingSource
            // 
            this.providersBindingSource.DataMember = "Providers";
            this.providersBindingSource.DataSource = this.diplomDataSet;
            // 
            // providersTableAdapter
            // 
            this.providersTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // supplyProductsBindingSource
            // 
            this.supplyProductsBindingSource.DataMember = "SupplyProducts";
            this.supplyProductsBindingSource.DataSource = this.diplomDataSet;
            // 
            // supplyProductsTableAdapter
            // 
            this.supplyProductsTableAdapter.ClearBeforeFill = true;
            // 
            // supplyProductsDataGridView
            // 
            this.supplyProductsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.supplyProductsDataGridView.AutoGenerateColumns = false;
            this.supplyProductsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.supplyProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplyProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.Price,
            this.dataGridViewTextBoxColumn6,
            this.TotalPrice,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.supplyProductsDataGridView.DataSource = this.supplyProductsBindingSource;
            this.supplyProductsDataGridView.Location = new System.Drawing.Point(12, 137);
            this.supplyProductsDataGridView.Name = "supplyProductsDataGridView";
            this.supplyProductsDataGridView.RowHeadersVisible = false;
            this.supplyProductsDataGridView.Size = new System.Drawing.Size(503, 130);
            this.supplyProductsDataGridView.TabIndex = 18;
            this.supplyProductsDataGridView.BindingContextChanged += new System.EventHandler(this.SupplyProductsDataGridView_BindingContextChanged);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "productID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Товар";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "count";
            this.dataGridViewTextBoxColumn6.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Общая цена";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "supplyProductID";
            this.dataGridViewTextBoxColumn3.HeaderText = "supplyProductID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "supplyID";
            this.dataGridViewTextBoxColumn4.HeaderText = "supplyID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // formSupplyEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 307);
            this.Controls.Add(this.supplyProductsDataGridView);
            this.Controls.Add(this.providerIDComboBox);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.employeeIDComboBox);
            this.Controls.Add(this.supplyIDTextBox);
            this.Controls.Add(this.suppliesBindingNavigator);
            this.Controls.Add(employeeIDLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(clientIDLabel);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.SupplyIDLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSupplyEx";
            this.Text = "Поставки товаров";
            this.Load += new System.EventHandler(this.formSupplyEx_Load);
            this.TextChanged += new System.EventHandler(this.SupplyIDTextBox_TextChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suppliesBindingNavigator)).EndInit();
            this.suppliesBindingNavigator.ResumeLayout(false);
            this.suppliesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplyProductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SupplyIDLabel;
        private DiplomDataSet diplomDataSet;
        private System.Windows.Forms.BindingSource suppliesBindingSource;
        private DiplomDataSetTableAdapters.SuppliesTableAdapter suppliesTableAdapter;
        private DiplomDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox supplyIDTextBox;
        private System.Windows.Forms.ComboBox employeeIDComboBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton suppliesBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator suppliesBindingNavigator;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.ComboBox providerIDComboBox;
        private System.Windows.Forms.BindingSource providersBindingSource;
        private DiplomDataSetTableAdapters.ProvidersTableAdapter providersTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private DiplomDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource supplyProductsBindingSource;
        private DiplomDataSetTableAdapters.SupplyProductsTableAdapter supplyProductsTableAdapter;
        private System.Windows.Forms.DataGridView supplyProductsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

    }
}