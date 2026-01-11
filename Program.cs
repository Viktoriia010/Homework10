namespace Homework10;

internal class Program
{
    static void Main(string[] args)
    {
        //Oceanarium oceanarium = new Oceanarium("Test Oceanarium", "Mushiv");
        //oceanarium.AddInhabitant(new Inhabitant() { Name = "Shark", Age = 12 });
        //oceanarium.AddInhabitant(new Inhabitant() { Name = "Dolphin", Age = 10 });
        //oceanarium.AddInhabitant(new Inhabitant() { Name = "Jellyfish", Age = 5 });

        //foreach (Inhabitant inhabitant in oceanarium)
        //{
        //    Console.WriteLine(inhabitant);
        //}


        string productType = "Electronics";
        Category<string> category = new Category<string>("Electronics");
        category.AddGoods(new Goods<string>("Laptop", 1500, DateTime.Now.AddDays(-10), productType));
        category.AddGoods(new Goods<string>("Headphones", 300, DateTime.Now.AddDays(-20), productType));
        category.AddGoods(new Goods<string>("Mouse", 150, DateTime.Now.AddMonths(-2), productType));
        category.AddGoods(new Goods<string>("Keyboard", 400, DateTime.Now.AddDays(-5), productType));

        foreach (var item in category)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        var newCategory = category.GetGoodsByPrice(100, 400);

        foreach (var item in newCategory)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();


        var newCategory2 = category.GetGoodsByDate(DateTime.Now.AddMonths(-1));

        foreach (var item in newCategory2)
        {
            Console.WriteLine(item);
        }
    }
}
