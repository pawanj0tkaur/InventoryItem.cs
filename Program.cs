using System;
public class InventoryItem
{
    // Properties
    public string ItemName { get; set; }
    public int ItemId { get; set; }
    public double Price { get; set; }
    public int QuantityInStock { get; set; }

    // Constructor
    public InventoryItem(string itemName, int itemId, double price, int quantityInStock)
    {
        // TODO: Initialize the properties with the values passed to the constructor.
        ItemName = itemName;
        ItemId = itemId;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    // Methods

    // Update the price of the item
    public void UpdatePrice(double newPrice)
    {
        Price = newPrice;
    }

    // Restock the item
    public void RestockItem(int additionalQuantity)
    {
        // TODO: Increase the item's stock quantity by the additional quantity.
        QuantityInStock += additionalQuantity;
    }

    // Sell an item
    public void SellItem(int quantitySold)
    {
        // TODO: Decrease the item's stock quantity by the quantity sold.
        if(quantitySold <= QuantityInStock)
        {
            QuantityInStock -= quantitySold;
        }
        // Make sure the stock doesn't go negative.
        else
        {
            Console.WriteLine("Not enough stock available to sell.");
        }
    }

    // Check if an item is in stock
    public  bool IsInStock()
    {
        // TODO: Return true if the item is in stock (quantity > 0), otherwise false.
        {
            return QuantityInStock > 0;
    }
}

    private void PrintDetails1()
    {
        // TODO: Print the details of the item (name, id, price, and stock quantity).
        Console.WriteLine($"ItemName: {ItemName}");
        Console.WriteLine($"Item ID: {ItemId}");
        Console.WriteLine($"Price: {Price:C}");
        Console.WriteLine($"Quantity in Stock: {QuantityInStock}");
    }
    class Program
{
        static void Main(string[] args)
        {
            // Creating instances of InventoryItem
            InventoryItem item1 = new InventoryItem("Laptop", 101, 1200.50, 10);
            InventoryItem item2 = new InventoryItem("Smartphone", 102, 800.30, 15);

            // TODO: Implement logic to interact with these objects.
            // Example tasks:
            // 1. Print details of all items.
            Console.WriteLine("Item1 Details:");
            item1.PrintDetails1();
            Console.WriteLine();
            Console.WriteLine("Item2 Details:");
            item2.PrintDetails();
            Console.WriteLine();
            // 2. Sell some items and then print the updated details.
            item1.SellItem(3);
            Console.WriteLine("After selling 3 items:");
            item1.PrintDetails();
            Console.WriteLine();
            // 3. Restock an item and print the updated details.
            item2.PrintDetails();
            Console.WriteLine("After restocking 5 items:");
            item2.PrintDetails();
            Console.WriteLine();
            // 4. Check if an item is in stock and print a message accordingly.
            Console.WriteLine($"Item 1 is {(item1.IsInStock() ? "in stock" : "out of stock")}.");
            Console.WriteLine($"Item 2 is {(item2.IsInStock() ? "in stock" : "out of stock")}.");
         }
}

    private void PrintDetails()
    {
        throw new NotImplementedException();
    }
}

