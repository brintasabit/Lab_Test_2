namespace MobileHandsetHome
{
    partial class SearchByPriceRange
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMinPrice = new System.Windows.Forms.TextBox();
            this.textBoxMaximunPrice = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.dataGridViewMobiles = new System.Windows.Forms.DataGridView();
            this.mobileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMobiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price Between";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "and";
            // 
            // textBoxMinPrice
            // 
            this.textBoxMinPrice.Location = new System.Drawing.Point(148, 83);
            this.textBoxMinPrice.Name = "textBoxMinPrice";
            this.textBoxMinPrice.Size = new System.Drawing.Size(182, 20);
            this.textBoxMinPrice.TabIndex = 1;
            // 
            // textBoxMaximunPrice
            // 
            this.textBoxMaximunPrice.Location = new System.Drawing.Point(430, 83);
            this.textBoxMaximunPrice.Name = "textBoxMaximunPrice";
            this.textBoxMaximunPrice.Size = new System.Drawing.Size(182, 20);
            this.textBoxMaximunPrice.TabIndex = 1;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(655, 81);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(78, 22);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // dataGridViewMobiles
            // 
            this.dataGridViewMobiles.AutoGenerateColumns = false;
            this.dataGridViewMobiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMobiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNumber,
            this.modelNameDataGridViewTextBoxColumn,
            this.imeiDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridViewMobiles.DataSource = this.mobileBindingSource;
            this.dataGridViewMobiles.Location = new System.Drawing.Point(125, 193);
            this.dataGridViewMobiles.Name = "dataGridViewMobiles";
            this.dataGridViewMobiles.Size = new System.Drawing.Size(535, 225);
            this.dataGridViewMobiles.TabIndex = 3;
            this.dataGridViewMobiles.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // mobileBindingSource
            // 
            this.mobileBindingSource.DataSource = typeof(MobileHandsetHome.Model.Mobile);
            // 
            // SerialNumber
            // 
            this.SerialNumber.HeaderText = "Sl#";
            this.SerialNumber.Name = "SerialNumber";
            // 
            // modelNameDataGridViewTextBoxColumn
            // 
            this.modelNameDataGridViewTextBoxColumn.DataPropertyName = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.HeaderText = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.Name = "modelNameDataGridViewTextBoxColumn";
            // 
            // imeiDataGridViewTextBoxColumn
            // 
            this.imeiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imeiDataGridViewTextBoxColumn.DataPropertyName = "Imei";
            this.imeiDataGridViewTextBoxColumn.HeaderText = "Imei";
            this.imeiDataGridViewTextBoxColumn.Name = "imeiDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // SearchByPriceRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewMobiles);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.textBoxMaximunPrice);
            this.Controls.Add(this.textBoxMinPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchByPriceRange";
            this.Text = "Search By Price Range";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMobiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMinPrice;
        private System.Windows.Forms.TextBox textBoxMaximunPrice;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView dataGridViewMobiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mobileBindingSource;
    }
}