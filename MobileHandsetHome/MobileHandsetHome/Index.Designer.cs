namespace MobileHandsetHome
{
    partial class Index
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
            this.SaveMobileButton = new System.Windows.Forms.Button();
            this.SearchPriceButton = new System.Windows.Forms.Button();
            this.SearchImeiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveMobileButton
            // 
            this.SaveMobileButton.Location = new System.Drawing.Point(242, 131);
            this.SaveMobileButton.Name = "SaveMobileButton";
            this.SaveMobileButton.Size = new System.Drawing.Size(263, 30);
            this.SaveMobileButton.TabIndex = 0;
            this.SaveMobileButton.Text = "Save Mobile Handset Information";
            this.SaveMobileButton.UseVisualStyleBackColor = true;
            this.SaveMobileButton.Click += new System.EventHandler(this.SaveMobileButton_Click);
            // 
            // SearchPriceButton
            // 
            this.SearchPriceButton.Location = new System.Drawing.Point(242, 184);
            this.SearchPriceButton.Name = "SearchPriceButton";
            this.SearchPriceButton.Size = new System.Drawing.Size(263, 34);
            this.SearchPriceButton.TabIndex = 0;
            this.SearchPriceButton.Text = "Search Mobile Handset By Price Range";
            this.SearchPriceButton.UseVisualStyleBackColor = true;
            this.SearchPriceButton.Click += new System.EventHandler(this.SearchPriceButton_Click);
            // 
            // SearchImeiButton
            // 
            this.SearchImeiButton.Location = new System.Drawing.Point(242, 238);
            this.SearchImeiButton.Name = "SearchImeiButton";
            this.SearchImeiButton.Size = new System.Drawing.Size(263, 35);
            this.SearchImeiButton.TabIndex = 0;
            this.SearchImeiButton.Text = "Search Mobile Handset By IMEI";
            this.SearchImeiButton.UseVisualStyleBackColor = true;
            this.SearchImeiButton.Click += new System.EventHandler(this.SearchImeiButton_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchImeiButton);
            this.Controls.Add(this.SearchPriceButton);
            this.Controls.Add(this.SaveMobileButton);
            this.Name = "Index";
            this.Text = "Index";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveMobileButton;
        private System.Windows.Forms.Button SearchPriceButton;
        private System.Windows.Forms.Button SearchImeiButton;
    }
}

