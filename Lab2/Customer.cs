using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Customer
    {
        private static int AccountNo = 100;
        private string fName;
        private string lName;
        private decimal kWhUsed;
        public const decimal adminFee = 12.00m;
        public const decimal kWhFee = 0.07m;
        private decimal BillAmount;

        public Customer() { }

        public Customer(string firstname, string lastname, decimal kWhused)
        {
            fName = firstname;
            lName = lastname;
            kWhUsed = kWhused;
            AccountNo++;
            BillAmount = adminFee + kWhUsed * kWhFee;

        }




    }


}
