
namespace Lab2
{
    partial class CreateCustomer
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
            this.LblInfo = new System.Windows.Forms.Label();
            this.LblFName = new System.Windows.Forms.Label();
            this.LblLName = new System.Windows.Forms.Label();
            this.LblkWhUsed = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtkWhUsed = new System.Windows.Forms.TextBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.LblInfo.Location = new System.Drawing.Point(95, 73);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(349, 28);
            this.LblInfo.TabIndex = 0;
            this.LblInfo.Text = "Create A New Customer Record";
            // 
            // LblFName
            // 
            this.LblFName.AutoSize = true;
            this.LblFName.Location = new System.Drawing.Point(44, 149);
            this.LblFName.Name = "LblFName";
            this.LblFName.Size = new System.Drawing.Size(88, 19);
            this.LblFName.TabIndex = 1;
            this.LblFName.Text = "First Name:";
            // 
            // LblLName
            // 
            this.LblLName.AutoSize = true;
            this.LblLName.Location = new System.Drawing.Point(44, 193);
            this.LblLName.Name = "LblLName";
            this.LblLName.Size = new System.Drawing.Size(86, 19);
            this.LblLName.TabIndex = 2;
            this.LblLName.Text = "Last Name:";
            // 
            // LblkWhUsed
            // 
            this.LblkWhUsed.AutoSize = true;
            this.LblkWhUsed.Location = new System.Drawing.Point(44, 237);
            this.LblkWhUsed.Name = "LblkWhUsed";
            this.LblkWhUsed.Size = new System.Drawing.Size(83, 19);
            this.LblkWhUsed.TabIndex = 3;
            this.LblkWhUsed.Text = "kWh Used:";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(150, 139);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(263, 29);
            this.txtFName.TabIndex = 4;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(150, 183);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(263, 29);
            this.txtLName.TabIndex = 5;
            // 
            // txtkWhUsed
            // 
            this.txtkWhUsed.Location = new System.Drawing.Point(150, 227);
            this.txtkWhUsed.Name = "txtkWhUsed";
            this.txtkWhUsed.Size = new System.Drawing.Size(263, 29);
            this.txtkWhUsed.TabIndex = 6;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSubmit.Location = new System.Drawing.Point(150, 276);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(119, 34);
            this.BtnSubmit.TabIndex = 7;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = false;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnReset.Location = new System.Drawing.Point(294, 276);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(119, 34);
            this.BtnReset.TabIndex = 8;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // CreateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(549, 360);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.txtkWhUsed);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.LblkWhUsed);
            this.Controls.Add(this.LblLName);
            this.Controls.Add(this.LblFName);
            this.Controls.Add(this.LblInfo);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "CreateCustomer";
            this.Text = "CreateCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Label LblFName;
        private System.Windows.Forms.Label LblLName;
        private System.Windows.Forms.Label LblkWhUsed;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtkWhUsed;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Button BtnReset;
    }
}