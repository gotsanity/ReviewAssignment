using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewAssignment
{
    internal class PremiumCustomer : Customer
    {
        public PremiumCustomer(
            string first,
            string last,
            string type = "Premium"
        ) : base(
            first,
            last,
            type
        )
        {
            DiscountAmount = 0.1m;
        }

        public override void CalculateDiscountAmount()
        {
            // Increment Transaction Counter (start a new transaction)
            NumOfTransactions++;

            Console.WriteLine("Performing a transaction");
        }
    }
}
