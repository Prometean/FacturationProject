using System;
using System.Collections.Generic;

public class Invoice
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string CustomerName { get; set; }
    public List<InvoiceItem> Items { get; set; }

    public decimal TotalAmount()
    {
        decimal total = 0;
        foreach (var item in Items)
        {
            total += item.TotalPrice();
        }
        return total;
    }
}
