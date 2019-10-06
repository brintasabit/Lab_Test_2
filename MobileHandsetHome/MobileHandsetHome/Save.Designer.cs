namespace MobileHandsetHome
{
    partial class Save
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
            this.labelModelName = new System.Windows.Forms.Label();
            this.labelImei = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxModelName = new System.Windows.Forms.TextBox();
            this.textBoxImei = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelModelName
            // 
            this.labelModelName.AutoSize = true;
            this.labelModelName.Location = new System.Drawing.Point(298, 151);
            this.labelModelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelModelName.Name = "labelModelName";
            this.labelModelName.Size = new System.Drawing.Size(98, 20);
            this.labelModelName.TabIndex = 0;
            this.labelModelName.Text = "Model Name";
            // 
            // labelImei
            // 
            this.labelImei.AutoSize = true;
            this.labelImei.Location = new System.Drawing.Point(298, 243);
            this.labelImei.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelImei.Name = "labelImei";
            this.labelImei.Size = new System.Drawing.Size(43, 20);
            this.labelImei.TabIndex = 0;
            this.labelImei.Text = "IMEI";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(298, 331);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(44, 20);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "Price";
            // 
            // textBoxModelName
            // 
            this.textBoxModelName.Location = new System.Drawing.Point(453, 146);
            this.textBoxModelName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxModelName.Name = "textBoxModelName";
            this.textBoxModelName.Size = new System.Drawing.Size(332, 26);
            this.textBoxModelName.TabIndex = 1;
            // 
            // textBoxImei
            // 
            this.textBoxImei.Location = new System.Drawing.Point(453, 232);
            this.textBoxImei.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxImei.Name = "textBoxImei";
            this.textBoxImei.Size = new System.Drawing.Size(332, 26);
            this.textBoxImei.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(453, 320);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(332, 26);
            this.textBoxPrice.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(675, 403);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(112, 45);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Save
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxImei);
            this.Controls.Add(this.textBoxModelName);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelImei);
            this.Controls.Add(this.labelModelName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Save";
            this.Text = "SaveInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelModelName;
        private System.Windows.Forms.Label labelImei;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxModelName;
        private System.Windows.Forms.TextBox textBoxImei;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button SaveButton;
    }
}