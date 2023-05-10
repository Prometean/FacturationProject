using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create sample invoice data
        Invoice invoice = new Invoice
        {
            Id = 1,
            Date = DateTime.Now,
            CustomerName = "John Doe",
            Items = new List<InvoiceItem>
            {
                new InvoiceItem { Id = 1, Description = "Product A", Price = 10, Quantity = 2 },
                new InvoiceItem { Id = 2, Description = "Product B", Price = 15, Quantity = 1 }
            }
        };

        // Display invoice information
        Console.WriteLine($"Invoice ID: {invoice.Id}");
        Console.WriteLine($"Date: {invoice.Date}");
        Console.WriteLine($"Customer: {invoice.CustomerName}\n");
        Console.WriteLine("Items:");

        foreach (var item in invoice.Items)
        {
            Console.WriteLine($"  {item.Description} - Price: {item.Price} x Quantity: {item.Quantity} = Total: {item.TotalPrice()}");
        }

        Console.WriteLine($"\nTotal Amount: {invoice.TotalAmount()}");
    }
}