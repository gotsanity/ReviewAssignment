using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewAssignment
{
    internal class ProCustomer : Customer
    {
        private int DiscountUpperLimit = 5;

        public ProCustomer(string first, string last, string type = "Pro") : base(first, last, type)
        {
            DiscountAmount = 0.25m;
        }

        public override void CalculateDiscountAmount()
        {
            // Increment Transaction Counter (start a new transaction)
            NumOfTransactions++;

            if (NumOfTransactions >= DiscountUpperLimit)
            {
                SetDiscountAmount(0.10m);
            }

            Console.WriteLine("Performing a transaction");
            Console.WriteLine("Sending a thank you note");
        }
    }
}
