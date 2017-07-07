using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You got this, girl!");
            // In Main method, create a list of value tuples that will hold individual transactions for a hardware business. Each tuple will store the product, the total amount of the transaction, and the quantity of the product.
            // (string name, int quantity, double price) product = ("Yo-yo", 1, 9.04);

            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();

            transactions.Add(("cat", 25.99, 1));
            transactions.Add(("dog", 5.01, 1));
            transactions.Add(("hamster", 12.25, 3));
            transactions.Add(("snake", 50.00, 1));
            transactions.Add(("elephant", 50000.65, 50));

            double totalProducts = 0;
            double totalRevenue = 0;
            
            foreach ((string product, double amount, int quantity) t in transactions)
            {
                // Iterate over the list of tuples and calculate how many total products you sold today, and what your total revenue was.
                // Logic goes here to look up quantity and amount in each transaction
                totalProducts = totalProducts + t.quantity;
                totalRevenue = totalRevenue + t.amount;
            }

            Console.WriteLine($"Items sold today: {totalProducts}");
            Console.WriteLine($"Total Revenue for today: ${totalRevenue}");
        }
    }
}
