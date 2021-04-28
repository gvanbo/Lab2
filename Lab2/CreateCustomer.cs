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

        public const decimal adminFee = 12.00m;
        public const decimal kWhFee = 0.07m;
        public List<int> Account = new List<int>(100);
        public List<string> FName = new List<string>(100);
        public List<string> LName = new List<string>(100);
        public List<decimal> kWhUsed = new List<decimal>(100);
        public List<decimal> BillTotal = new List<decimal>(100);
        public int AccountNo = 0;

        private void BtnReset_Click(object sender, EventArgs e)
        {
            FieldReset();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            
            NewCustomer();
            FieldReset();

        }

        public void NewCustomer()
        {
            string first = txtFName.Text;
            string last = txtLName.Text;
            decimal energy = decimal.Parse(txtkWhUsed.Text);
            AccountNo++;
            int actNumber = AccountNo;

            decimal totalBill = energy * kWhFee + adminFee; 

            Customer cust = new Customer(first, last, energy);
            MessageBox.Show($"New Customer Created: \n{first} {last}. \n" +
                $"Total Bill Amount is: {totalBill}\n" +
                $"Customer Account No: {actNumber}");
            
            
            // Add customer information to lists
            Account.Add(actNumber);
            FName.Add(first);
            LName.Add(last);
            kWhUsed.Add(energy);
            BillTotal.Add(totalBill);

            //Display Cumulative Totals
            DisplayTotals();
        }



        public void FieldReset()
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtkWhUsed.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtAccountNo.Text);

            txtFullName.Text = $"{FName[x - 1]} {LName[x - 1]}";
            txtEnergyUsed.Text = kWhUsed[x - 1].ToString();
            txtBillTotal.Text = BillTotal[x - 1].ToString();

        }

        private void DisplayTotals()
        {
            int totalCustomers = GetTotalCustomers();
            decimal totalK = GetTotalkWh();
            decimal billAvg = GetAverageBill();
            decimal avgKWH = GetAveragekWh();
            txtTotalCustomers.Text = totalCustomers.ToString();
            txtTotalkWh.Text = totalK.ToString();
            txtAverageBill.Text = billAvg.ToString("c");
            txtAveragekWh.Text = avgKWH.ToString();
        }

        private int GetTotalCustomers()
        {
            int counter = 0;
            foreach (int item in Account)
            {
                counter++;
            }
            return counter;
        }

        private decimal GetTotalkWh()
        {
            decimal listTotalkWh = 0;
            foreach (var item in kWhUsed)
            {
                listTotalkWh += item;
            }
            return listTotalkWh;
        }

        private decimal GetAverageBill()
        {
            decimal allBillsTotal = 0;
            decimal countBills = 0;
            foreach (var item in BillTotal)
            {
                countBills++;
                allBillsTotal += item;
            }
            decimal averageBill = allBillsTotal / countBills;
            return averageBill;
        }

        private decimal GetAveragekWh()
        {
            decimal count = 0;
            decimal energy = 0;
            foreach (var item in kWhUsed)
            {
                count++;
                energy += item;
            }
            decimal averagekWh = energy / count;
            return averagekWh;

        }




    }
}
