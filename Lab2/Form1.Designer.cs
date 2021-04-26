
namespace Lab2
{
    partial class LblWelcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCreateCustomer = new System.Windows.Forms.Button();
            this.BtnCheckRecords = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCreateCustomer
            // 
            this.BtnCreateCustomer.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCreateCustomer.Location = new System.Drawing.Point(68, 111);
            this.BtnCreateCustomer.Name = "BtnCreateCustomer";
            this.BtnCreateCustomer.Size = new System.Drawing.Size(135, 48);
            this.BtnCreateCustomer.TabIndex = 0;
            this.BtnCreateCustomer.Text = "Create New Customer";
            this.BtnCreateCustomer.UseVisualStyleBackColor = true;
            this.BtnCreateCustomer.Click += new System.EventHandler(this.BtnCreateCustomer_Click);
            // 
            // BtnCheckRecords
            // 
            this.BtnCheckRecords.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnCheckRecords.Location = new System.Drawing.Point(68, 191);
            this.BtnCheckRecords.Name = "BtnCheckRecords";
            this.BtnCheckRecords.Size = new System.Drawing.Size(135, 48);
            this.BtnCheckRecords.TabIndex = 1;
            this.BtnCheckRecords.Text = "Check Records";
            this.BtnCheckRecords.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(68, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome";
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnExit.Location = new System.Drawing.Point(68, 270);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(135, 48);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            // 
            // LblWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(284, 381);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCheckRecords);
            this.Controls.Add(this.BtnCreateCustomer);
            this.Font = new System.Drawing.Font("Verdana", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Name = "LblWelcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateCustomer;
        private System.Windows.Forms.Button BtnCheckRecords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExit;
    }
}

