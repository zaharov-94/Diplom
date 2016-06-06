namespace Diplom
{
    partial class Home
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
            this.dataSetReports = new Diplom.DataSetReports();
            this.ostatokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ostatokTableAdapter = new Diplom.DataSetReportsTableAdapters.OstatokTableAdapter();
            this.tableAdapterManager = new Diplom.DataSetReportsTableAdapters.TableAdapterManager();
            this.ostatokDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ostatokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ostatokDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetReports
            // 
            this.dataSetReports.DataSetName = "DataSetReports";
            this.dataSetReports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ostatokBindingSource
            // 
            this.ostatokBindingSource.DataMember = "Ostatok";
            this.ostatokBindingSource.DataSource = this.dataSetReports;
            // 
            // ostatokTableAdapter
            // 
            this.ostatokTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Diplom.DataSetReportsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ostatokDataGridView
            // 
            this.ostatokDataGridView.AllowUserToAddRows = false;
            this.ostatokDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ostatokDataGridView.AutoGenerateColumns = false;
            this.ostatokDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ostatokDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ostatokDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.ostatokDataGridView.DataSource = this.ostatokBindingSource;
            this.ostatokDataGridView.Enabled = false;
            this.ostatokDataGridView.Location = new System.Drawing.Point(12, 42);
            this.ostatokDataGridView.Name = "ostatokDataGridView";
            this.ostatokDataGridView.RowHeadersVisible = false;
            this.ostatokDataGridView.Size = new System.Drawing.Size(187, 283);
            this.ostatokDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Остатки товаров";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "razn";
            this.dataGridViewTextBoxColumn2.HeaderText = "Количество, ед";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(481, 356);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ostatokDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Домашняя";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ostatokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ostatokDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetReports dataSetReports;
        private System.Windows.Forms.BindingSource ostatokBindingSource;
        private DataSetReportsTableAdapters.OstatokTableAdapter ostatokTableAdapter;
        private DataSetReportsTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView ostatokDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;


    }
}