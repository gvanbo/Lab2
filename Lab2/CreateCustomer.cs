using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab2
{
    public partial class CreateCustomer : Form
    {
        public CreateCustomer()
        {
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtkWhUsed.Text = "";
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            
            
            string first = txtFName.Text;
            string last = txtLName.Text;
            decimal energy = decimal.Parse(txtkWhUsed.Text);


        }
    }
}
