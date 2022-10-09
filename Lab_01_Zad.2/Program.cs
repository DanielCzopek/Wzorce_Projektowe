using System;
using System.Collections.Generic;


public abstract class ProductPrototype
{

    public decimal Price { get; set; }

    public ProductPrototype(decimal price)
    {
        Price = price;
    }

    public ProductPrototype Clone() =>
      (ProductPrototype)this.MemberwiseClone();


}

public class Bread : ProductPrototype
{
    public Bread(decimal price) : base(price) { }
}

public class Butter : ProductPrototype
{
    public Butter(decimal price) : base(price) { }
}


public class Supermarket
{

    private Dictionary<string, ProductPrototype> _productList = new Dictionary<string, ProductPrototype>();

    public void AddProduct(string key, ProductPrototype productPrototype)
    {
        _productList.Add(key, productPrototype);
    }

    public ProductPrototype GetClonedProduct(string key) => _productList[key].Clone();

}


class MainClass
{
    public static void Main(string[] args)
    {

        Supermarket supermarket = new Supermarket();

        supermarket.AddProduct("Bread", new Bread(5.30m));
        supermarket.AddProduct("Butter", new Butter(5.30m));

        var product = supermarket.GetClonedProduct("Bread");
        Console.WriteLine(String.Format("Bread - {0} zł", product.Price));

        product = supermarket.GetClonedProduct("Butter");
        Console.WriteLine(String.Format("Butter - {0} zł", product.Price));
    }
}