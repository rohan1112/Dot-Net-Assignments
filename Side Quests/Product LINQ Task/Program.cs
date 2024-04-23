using System;
using System.Linq;
class ProductInfo
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int NumberInStock { get; set; }
    public override string ToString()
    {
        return string.Format("Name={0}, Description={1}, Number in Stock={2}",
        Name, Description, NumberInStock);
    }
}
class entry
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** Fun with Query Expressions *****\n");
        // This array will be the basis of our testing...
        ProductInfo[] itemsInStock = new[]
         {
        new ProductInfo{ Name = "Mac's Coffee", Description = "Coffee with TEETH",
                                         NumberInStock = 24},
        new ProductInfo { Name = "Milk Maid Milk",Description = "Milk cow's love",
                                            NumberInStock = 100},
         new ProductInfo{ Name = "Pure Silk Tofu",  Description = "Bland as Possible",
                                            NumberInStock = 120},
        new ProductInfo{ Name = "Cruchy Pops",  Description = "Cheezy, peppery goodness",
                                        NumberInStock = 2},
       new ProductInfo{ Name = "RipOff Water",   Description = "From the tap to your wallet",
                                        NumberInStock = 100},
    new ProductInfo{ Name = "Classic Valpo Pizza", Description = "Everyone loves pizza!",
         NumberInStock = 73}
        };

        System.Console.WriteLine("All the Products");

        var product = from prod in itemsInStock select prod;
        foreach (var item in product)
        {
            System.Console.WriteLine(item);
        }

        System.Console.WriteLine("*******************************************************************");

        System.Console.WriteLine("All the Products Name");

        // var productName = from prod in itemsInStock select prod.Name;
        var productName =itemsInStock.Select(product=>product.Name);

        foreach (var item in productName)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("*******************************************************************");

        System.Console.WriteLine("All the Products Part with anonynoums object");
        // var productPart = from prod in itemsInStock select new { name = prod.Name, des = prod.Description, stocknum = prod.NumberInStock };
        var productPart =itemsInStock.Select(prod=>new { name = prod.Name, des = prod.Description, stocknum = prod.NumberInStock });
        foreach (var item in productPart)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("*******************************************************************");
        System.Console.WriteLine("All the Products having stock 100");
        // var product100 = from prod in itemsInStock where prod.NumberInStock == 100 select new { name = prod.Name, des = prod.Description };
         var product100 =itemsInStock.Where(p=>p.NumberInStock==100).Select( p=>new {name=p.Name,des=p.Description});
        foreach (var item in product100)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("*******************************************************************");
        System.Console.WriteLine("All the Products name containing 's' in the name");
        // var producthavings = from prod in itemsInStock where prod.Name.Contains('s') orderby prod.Name select new { name = prod.Name };
         var producthavings =itemsInStock.Where(p=>p.Name.Contains('s')).OrderBy(p=>p.Name).Select( p=>new {name=p.Name});
        foreach (var item in producthavings)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("*******************************************************************");
        System.Console.WriteLine("All the Products 's' in the name in desecending order ");
        // var producthavingsdesc = from prod in itemsInStock where prod.Name.Contains('s') orderby prod.Name descending select new { name = prod.Name };
         var producthavingsdesc =itemsInStock.Where(p=>p.Name.Contains('s')).OrderByDescending(p=>p.Name).Select( p=>new {name=p.Name});
        foreach (var item in producthavingsdesc)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine("*******************************************************************");
        System.Console.WriteLine("All the Products where stock is less than 100");
        // var productstocklessthan100 = from prod in itemsInStock where prod.NumberInStock < 100 select prod.Name;
         var productstocklessthan100 =itemsInStock.Where(p=>p.NumberInStock<100).Select( p=>new {name=p.Name});
        System.Console.WriteLine(productstocklessthan100.Count());

        System.Console.WriteLine("*******************************************************************");
        System.Console.WriteLine("Min , Max, Avg of number in stocks  ");
        // var productstocklminmaxavg = from prod in itemsInStock select prod.NumberInStock;
         var productstocklminmaxavg =itemsInStock.Select( p=>p.NumberInStock);
        System.Console.WriteLine("Min: " + productstocklminmaxavg.Min());
        System.Console.WriteLine("Max: " + productstocklminmaxavg.Max());
        System.Console.WriteLine("Avg: " + productstocklminmaxavg.Average());










    }
}