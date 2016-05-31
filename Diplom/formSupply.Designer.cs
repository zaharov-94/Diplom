namespace Diplom
{
    partial class formSupply
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
            System.Windows.Forms.Label providerIDLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.diplomDataSet = new Diplom.DiplomDataSet();
            this.SuppliesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Diplom.DiplomDataSetTableAdapters.TableAdapterManager();
            this.productsTableAdapter = new Diplom.DiplomDataSetTableAdapters.ProductsTableAdapter();
            this.SupplyProductsTableAdapter = new Diplom.DiplomDataSetTableAdapters.SupplyProductsTableAdapter();
            this.providersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SupplyProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SupplyProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplyProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAddSupply = new System.Windows.Forms.Button();
            this.SuppliesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Diplom.DiplomDataSetTableAdapters.ClientsTableAdapter();
            this.labelCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.providersTableAdapter = new Diplom.DiplomDataSetTableAdapters.ProvidersTableAdapter();
            this.supplyProductsTableAdapter1 = new Diplom.DiplomDataSetTableAdapters.SupplyProductsTableAdapter();
            this.providerIDComboBox = new System.Windows.Forms.ComboBox();
            providerIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplyProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplyProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplyProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // providerIDLabel
            // 
            providerIDLabel.AutoSize = true;
            providerIDLabel.Location = new System.Drawing.Point(147, 95);
            providerIDLabel.Name = "providerIDLabel";
            providerIDLabel.Size = new System.Drawing.Size(62, 13);
            providerIDLabel.TabIndex = 9;
            providerIDLabel.Text = "provider ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supply";
            // 
            // diplomDataSet
            // 
            this.diplomDataSet.DataSetName = "DiplomDataSet";
            this.diplomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SuppliesBindingSource
            // 
            this.SuppliesBindingSource.DataMember = "Supplies";
            this.SuppliesBindingSource.DataSource = this.diplomDataSet;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.OrderProductsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.ProvidersTableAdapter = null;
            this.tableAdapterManager.SuppliesTableAdapter = null;
            this.tableAdapterManager.SupplyProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Diplom.DiplomDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // SupplyProductsTableAdapter
            // 
            this.SupplyProductsTableAdapter.ClearBeforeFill = true;
            // 
            // providersBindingSource
            // 
            this.providersBindingSource.DataMember = "Providers";
            this.providersBindingSource.DataSource = this.diplomDataSet;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.diplomDataSet;
            // 
            // SupplyProductsBindingSource
            // 
            this.SupplyProductsBindingSource.DataMember = "SupplyProducts";
            this.SupplyProductsBindingSource.DataSource = this.diplomDataSet;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.diplomDataSet;
            // 
            // SupplyProductsDataGridView
            // 
            this.SupplyProductsDataGridView.AutoGenerateColumns = false;
            this.SupplyProductsDataGridView.CausesValidation = false;
            this.SupplyProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplyProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.price,
            this.totalPrice});
            this.SupplyProductsDataGridView.DataSource = this.SupplyProductBindingSource;
            this.SupplyProductsDataGridView.Location = new System.Drawing.Point(22, 129);
            this.SupplyProductsDataGridView.Name = "SupplyProductsDataGridView";
            this.SupplyProductsDataGridView.RowHeadersVisible = false;
            this.SupplyProductsDataGridView.Size = new System.Drawing.Size(462, 84);
            this.SupplyProductsDataGridView.TabIndex = 6;
            this.SupplyProductsDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.SupplyProductsDataGridView_CellBeginEdit);
            this.SupplyProductsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplyProductsDataGridView_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataSource = this.productsBindingSource2;
            this.dataGridViewTextBoxColumn3.DisplayMember = "name";
            this.dataGridViewTextBoxColumn3.HeaderText = "productID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "productID";
            // 
            // productsBindingSource2
            // 
            this.productsBindingSource2.DataMember = "Products";
            this.productsBindingSource2.DataSource = this.diplomDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "count";
            this.dataGridViewTextBoxColumn4.HeaderText = "count";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // price
            // 
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // totalPrice
            // 
            this.totalPrice.DataPropertyName = "SupplyProductID";
            this.totalPrice.HeaderText = "Общая цена";
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.ReadOnly = true;
            // 
            // SupplyProductBindingSource
            // 
            this.SupplyProductBindingSource.DataSource = typeof(Diplom.Models.SupplyProduct);
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.diplomDataSet;
            // 
            // buttonAddSupply
            // 
            this.buttonAddSupply.Location = new System.Drawing.Point(409, 233);
            this.buttonAddSupply.Name = "buttonAddSupply";
            this.buttonAddSupply.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSupply.TabIndex = 7;
            this.buttonAddSupply.Text = "Оформить";
            this.buttonAddSupply.UseVisualStyleBackColor = true;
            this.buttonAddSupply.Click += new System.EventHandler(this.buttonAddSupply_Click);
            // 
            // SuppliesBindingSource1
            // 
            this.SuppliesBindingSource1.DataMember = "Supplies";
            this.SuppliesBindingSource1.DataSource = this.diplomDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(277, 233);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(34, 13);
            this.labelCount.TabIndex = 8;
            this.labelCount.Text = "count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Общая цена:";
            // 
            // providersTableAdapter
            // 
            this.providersTableAdapter.ClearBeforeFill = true;
            // 
            // supplyProductsTableAdapter1
            // 
            this.supplyProductsTableAdapter1.ClearBeforeFill = true;
            // 
            // providerIDComboBox
            // 
            this.providerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.providersBindingSource, "providerID", true));
            this.providerIDComboBox.DataSource = this.providersBindingSource;
            this.providerIDComboBox.DisplayMember = "name";
            this.providerIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.providerIDComboBox.FormattingEnabled = true;
            this.providerIDComboBox.Location = new System.Drawing.Point(215, 92);
            this.providerIDComboBox.Name = "providerIDComboBox";
            this.providerIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.providerIDComboBox.TabIndex = 10;
            this.providerIDComboBox.ValueMember = "providerID";
            this.providerIDComboBox.DropDownClosed += new System.EventHandler(this.providerIDComboBox_DropDownClosed);
            this.providerIDComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.providerIDComboBox_MouseClick);
            // 
            // formSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(507, 285);
            this.Controls.Add(providerIDLabel);
            this.Controls.Add(this.providerIDComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonAddSupply);
            this.Controls.Add(this.SupplyProductsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSupply";
            this.Text = "formSupply";
            this.Load += new System.EventHandler(this.formSupply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diplomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplyProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplyProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupplyProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppliesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DiplomDataSet diplomDataSet;
        private System.Windows.Forms.BindingSource SuppliesBindingSource;
        private DiplomDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DiplomDataSetTableAdapters.SupplyProductsTableAdapter SupplyProductsTableAdapter;
        private System.Windows.Forms.BindingSource SupplyProductsBindingSource;
        private DiplomDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.DataGridView SupplyProductsDataGridView;
        private System.Windows.Forms.Button buttonAddSupply;
        private System.Windows.Forms.BindingSource SuppliesBindingSource1;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private DiplomDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource SupplyProductBindingSource;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource providersBindingSource;
        private DiplomDataSetTableAdapters.ProvidersTableAdapter providersTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource productsBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
        private DiplomDataSetTableAdapters.SupplyProductsTableAdapter supplyProductsTableAdapter1;
        private System.Windows.Forms.ComboBox providerIDComboBox;
    }
}