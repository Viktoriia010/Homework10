using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10;

internal class Goods<T>
{
    public string? Name { get; set; }
    public double Price { get; set; }
    public DateTime Date { get; set; }

    public T Type { get; set; }

    public Goods()
    {

    }
    public Goods(string name, double price, DateTime date, T type)
    {
        Name = name;
        Price = price;
        Date = date;
        Type = type;
     }

    public override string ToString()
    {
        return ($"Name: {Name}, price: {Price} грн, date: {Date.ToShortDateString()}, type: {Type}"); 
    }
}
