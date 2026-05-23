namespace Task_3_for_DA
{
    partial class MainForm
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
            this.btnInventoryManagement = new System.Windows.Forms.Button();
            this.btnOrderProcessing = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnInventoryManagement
            // 
            this.btnInventoryManagement.Location = new System.Drawing.Point(16, 13);
            this.btnInventoryManagement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInventoryManagement.Name = "btnInventoryManagement";
            this.btnInventoryManagement.Size = new System.Drawing.Size(707, 82);
            this.btnInventoryManagement.TabIndex = 18;
            this.btnInventoryManagement.Text = "Inventory Management";
            this.btnInventoryManagement.UseVisualStyleBackColor = true;
            this.btnInventoryManagement.Click += new System.EventHandler(this.btnInventoryManagement_Click);
            // 
            // btnOrderProcessing
            // 
            this.btnOrderProcessing.Location = new System.Drawing.Point(731, 13);
            this.btnOrderProcessing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrderProcessing.Name = "btnOrderProcessing";
            this.btnOrderProcessing.Size = new System.Drawing.Size(741, 82);
            this.btnOrderProcessing.TabIndex = 19;
            this.btnOrderProcessing.Text = "Order Processing";
            this.btnOrderProcessing.UseVisualStyleBackColor = true;
            this.btnOrderProcessing.Click += new System.EventHandler(this.btnOrderProcessing_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 116);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1456, 743);
            this.panel1.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 874);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOrderProcessing);
            this.Controls.Add(this.btnInventoryManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInventoryManagement;
        private System.Windows.Forms.Button btnOrderProcessing;
        private System.Windows.Forms.Panel panel1;
    }
}