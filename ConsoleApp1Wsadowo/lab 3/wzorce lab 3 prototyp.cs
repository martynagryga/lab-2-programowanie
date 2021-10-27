using System;
using System.Collections.Generic;


public abstract class ProductPrototype
{
    public decimal Price { get; internal set; }

    public ProductPrototype(decimal price)
    {
        this.Price = price;
    }

    

    public ProductPrototype Clone()
    {
        return (ProductPrototype)this.MemberwiseClone();
    }

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
    private bool firstLoaf = true;

    public void AddProduct(string key, ProductPrototype productPrototype)
    {
        _productList.Add(key, productPrototype);
    }

    public ProductPrototype GetClonedProduct(string key)
    {
        
        ProductPrototype obj =_productList[key].Clone();
        if (key == "Bread" && firstLoaf )
        {
            firstLoaf = false;
            obj.Price *= 0.9m;
        }
        return obj;
    }

}


class MainClass
{
    public static void Main(string[] args)
    {

        Supermarket supermarket = new Supermarket();
        supermarket.AddProduct("Butter", new Butter(5.30m));
        supermarket.AddProduct("Bread", new Bread(9.50m));


        
        ProductPrototype product = supermarket.GetClonedProduct("Bread");
        ProductPrototype product2 = supermarket.GetClonedProduct("Bread");
        ProductPrototype product3 = supermarket.GetClonedProduct("Butter");
        Console.WriteLine(String.Format("Bread - {0} zł", product2.Price + "zł > " + product.Price.ToString("F2")) );
        Console.WriteLine(String.Format("Bread - {0} zł", product2.Price));
        Console.WriteLine(String.Format("Butter - {0} zł", product3.Price));


    }
}