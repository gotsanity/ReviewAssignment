using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewAssignment
{
    internal class TrialCustomer : Customer
    {
        private int DiscountUpperLimit = 3;

        public TrialCustomer(string first, string last, string type = "Trial") : base(first, last, type)
        {
            DiscountAmount = 0.1m;
        }

        public override void CalculateDiscountAmount()
        {
            // Increment Transaction Counter (start a new transaction)
            NumOfTransactions++;

            if (NumOfTransactions >= DiscountUpperLimit)
            {
                SetDiscountAmount(0);
            }

            Console.WriteLine("Performing a transaction");
        }

        public void DoStuff()
        {
            Console.WriteLine("Trial customer does stuff");
        }
    }
}
