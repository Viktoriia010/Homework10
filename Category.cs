using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10;

internal class Category<T> : IEnumerable<Goods<T>>
{
    public string? Name { get; set; }
    List<Goods<T>> goods = new List<Goods<T>>();

    public void AddGoods(Goods<T> good)
    {
        goods.Add(good);
    }

    public IEnumerator<Goods<T>> GetEnumerator()
    {
        return goods.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public Category(string name)
    {
        Name = name;
    }

    public List<Goods<T>> GetGoodsByPrice(double num, double num2)
    {
        List<Goods<T>> newGoods = new List<Goods<T>>();
        double min = (num > num2)? num2 : num;
        double max = (num > num2)? num : num2;
        foreach (var item in goods)
        {
            if (item.Price >= min && item.Price <= max)
            {
                newGoods.Add(item);
            }
        }

        return newGoods;
    }

    public List<Goods<T>> GetGoodsByDate(DateTime fromDate)
    {
        List<Goods<T>> newGoods = new List<Goods<T>>();

        foreach (var item in goods)
        {
            if (item.Date >= fromDate)
            {
                newGoods.Add(item);
            }
        }

        return newGoods;
    }
}
