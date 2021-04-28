
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
            this.txtEnergyUsed = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.txtBillTotal = new System.Windows.Forms.TextBox();
            this.lblBillTotal = new System.Windows.Forms.Label();
            this.lblAccountNo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.txtTotalCustomers = new System.Windows.Forms.TextBox();
            this.txtTotalkWh = new System.Windows.Forms.TextBox();
            this.lblTotalkWh = new System.Windows.Forms.Label();
            this.txtAveragekWh = new System.Windows.Forms.TextBox();
            this.lblAveragekWh = new System.Windows.Forms.Label();
            this.txtAverageBill = new System.Windows.Forms.TextBox();
            this.lblAverageBill = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.LblInfo.Location = new System.Drawing.Point(64, 55);
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
            // txtEnergyUsed
            // 
            this.txtEnergyUsed.Location = new System.Drawing.Point(621, 227);
            this.txtEnergyUsed.Name = "txtEnergyUsed";
            this.txtEnergyUsed.Size = new System.Drawing.Size(263, 29);
            this.txtEnergyUsed.TabIndex = 15;

            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(621, 183);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(263, 29);
            this.txtFullName.TabIndex = 14;

            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Location = new System.Drawing.Point(621, 139);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(263, 29);
            this.txtAccountNo.TabIndex = 13;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(515, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "kWh Used:";

            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(515, 193);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(83, 19);
            this.lblFullName.TabIndex = 11;
            this.lblFullName.Text = "Full Name:";

            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResults.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResults.Location = new System.Drawing.Point(703, 55);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(87, 28);
            this.lblResults.TabIndex = 9;
            this.lblResults.Text = "Results";
            // 
            // txtBillTotal
            // 
            this.txtBillTotal.Location = new System.Drawing.Point(621, 276);
            this.txtBillTotal.Name = "txtBillTotal";
            this.txtBillTotal.Size = new System.Drawing.Size(263, 29);
            this.txtBillTotal.TabIndex = 17;
            // 
            // lblBillTotal
            // 
            this.lblBillTotal.AutoSize = true;
            this.lblBillTotal.Location = new System.Drawing.Point(515, 286);
            this.lblBillTotal.Name = "lblBillTotal";
            this.lblBillTotal.Size = new System.Drawing.Size(71, 19);
            this.lblBillTotal.TabIndex = 16;
            this.lblBillTotal.Text = "Bill Total:";
            // 
            // lblAccountNo
            // 
            this.lblAccountNo.AutoSize = true;
            this.lblAccountNo.Location = new System.Drawing.Point(515, 142);
            this.lblAccountNo.Name = "lblAccountNo";
            this.lblAccountNo.Size = new System.Drawing.Size(89, 19);
            this.lblAccountNo.TabIndex = 19;
            this.lblAccountNo.Text = "AccountNo:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearch.Location = new System.Drawing.Point(640, 86);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(227, 37);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Enter Account No & Click Me";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.AutoSize = true;
            this.lblTotalCustomers.Location = new System.Drawing.Point(44, 415);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(122, 19);
            this.lblTotalCustomers.TabIndex = 21;
            this.lblTotalCustomers.Text = "Total Customers";
            // 
            // txtTotalCustomers
            // 
            this.txtTotalCustomers.Location = new System.Drawing.Point(53, 446);
            this.txtTotalCustomers.Name = "txtTotalCustomers";
            this.txtTotalCustomers.Size = new System.Drawing.Size(100, 29);
            this.txtTotalCustomers.TabIndex = 22;
            // 
            // txtTotalkWh
            // 
            this.txtTotalkWh.Location = new System.Drawing.Point(271, 446);
            this.txtTotalkWh.Name = "txtTotalkWh";
            this.txtTotalkWh.Size = new System.Drawing.Size(100, 29);
            this.txtTotalkWh.TabIndex = 24;
            // 
            // lblTotalkWh
            // 
            this.lblTotalkWh.AutoSize = true;
            this.lblTotalkWh.Location = new System.Drawing.Point(281, 415);
            this.lblTotalkWh.Name = "lblTotalkWh";
            this.lblTotalkWh.Size = new System.Drawing.Size(81, 19);
            this.lblTotalkWh.TabIndex = 23;
            this.lblTotalkWh.Text = "Total kWH";
            // 
            // txtAveragekWh
            // 
            this.txtAveragekWh.Location = new System.Drawing.Point(703, 446);
            this.txtAveragekWh.Name = "txtAveragekWh";
            this.txtAveragekWh.Size = new System.Drawing.Size(100, 29);
            this.txtAveragekWh.TabIndex = 28;
            // 
            // lblAveragekWh
            // 
            this.lblAveragekWh.AutoSize = true;
            this.lblAveragekWh.Location = new System.Drawing.Point(699, 415);
            this.lblAveragekWh.Name = "lblAveragekWh";
            this.lblAveragekWh.Size = new System.Drawing.Size(104, 19);
            this.lblAveragekWh.TabIndex = 27;
            this.lblAveragekWh.Text = "Average kWH";
            // 
            // txtAverageBill
            // 
            this.txtAverageBill.Location = new System.Drawing.Point(486, 446);
            this.txtAverageBill.Name = "txtAverageBill";
            this.txtAverageBill.Size = new System.Drawing.Size(100, 29);
            this.txtAverageBill.TabIndex = 26;
            // 
            // lblAverageBill
            // 
            this.lblAverageBill.AutoSize = true;
            this.lblAverageBill.Location = new System.Drawing.Point(476, 415);
            this.lblAverageBill.Name = "lblAverageBill";
            this.lblAverageBill.Size = new System.Drawing.Size(91, 19);
            this.lblAverageBill.TabIndex = 25;
            this.lblAverageBill.Text = "Average Bill";
            // 
            // CreateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(991, 534);
            this.Controls.Add(this.txtAveragekWh);
            this.Controls.Add(this.lblAveragekWh);
            this.Controls.Add(this.txtAverageBill);
            this.Controls.Add(this.lblAverageBill);
            this.Controls.Add(this.txtTotalkWh);
            this.Controls.Add(this.lblTotalkWh);
            this.Controls.Add(this.txtTotalCustomers);
            this.Controls.Add(this.lblTotalCustomers);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblAccountNo);
            this.Controls.Add(this.txtBillTotal);
            this.Controls.Add(this.lblBillTotal);
            this.Controls.Add(this.txtEnergyUsed);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtAccountNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblResults);
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
        private System.Windows.Forms.TextBox txtEnergyUsed;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblBillTotal;
        private System.Windows.Forms.Label lblAccountNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtBillTotal;
        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.TextBox txtTotalCustomers;
        private System.Windows.Forms.TextBox txtTotalkWh;
        private System.Windows.Forms.Label lblTotalkWh;
        private System.Windows.Forms.TextBox txtAveragekWh;
        private System.Windows.Forms.Label lblAveragekWh;
        private System.Windows.Forms.TextBox txtAverageBill;
        private System.Windows.Forms.Label lblAverageBill;
    }
}