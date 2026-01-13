namespace ReviewAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer jesse = new TrialCustomer("Jesse", "Harlan");
            Customer sarah = new PremiumCustomer("Sarah", "Harlan");
            Customer ashton = new ProCustomer("Ashton", "Harlan");

            DoPurchases(jesse);
            DoPurchases(sarah);
            DoPurchases(ashton);
        }

        static void DoPurchases(Customer customer)
        {
            Console.WriteLine("Starting Purchases");
            customer.PrintName();
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                // print the resulting discount
                Console.WriteLine($"Customer's discount is: {customer.DiscountAmount}");

                // do a purchase for the customer
                customer.CalculateDiscountAmount();
            }
        }
    }
}
