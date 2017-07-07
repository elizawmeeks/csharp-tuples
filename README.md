# csharp-tuples
NSS Exercise.

## Instructions

In Main method, create a list of value tuples that will hold individual transactions for a hardware business. Each tuple will store the product, the total amount of the transaction, and the quantity of the product.
```
List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
```
Add 5, or more, transactions to the list.
Iterate over the list of tuples and calculate how many total products you sold today, and what your total revenue was.

```
foreach ((string product, double amount, int quantity) t in transactions)
{
    // Logic goes here to look up quantity and amount in each transaction
}
```