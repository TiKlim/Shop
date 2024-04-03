using System.Collections.Generic;

namespace Shop;

public class DataBase
{
    public List<Product> Products = new List<Product>()
    {
        new Product("pivo", 100),
        new Product("pivo1", 100),
        new Product("pivo2", 100),
        new Product("pivo3", 100),
        new Product("pivo4", 100),
        new Product("pivo5", 100),
        new Product("pivo6", 100)
    };
}