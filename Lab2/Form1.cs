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
    public partial class LblWelcome : Form
    {
        public LblWelcome()
        {
            InitializeComponent();
        }

        private void BtnCreateCustomer_Click(object sender, EventArgs e)
        {
            CreateCustomer displayCreateCustomer = new CreateCustomer();
            displayCreateCustomer.ShowDialog();
        }
    }
}
