using System.Collections.Generic;

namespace Shop;

public class DataBase
{
    public List<Product> Products = new List<Product>()
    {
        new Product("pivo", 100,"foods"),
        new Product("appple", 100,"foods"),
        new Product("pivo2", 100,"technic"),
        new Product("pivo3", 100,"technic"),
        new Product("pivo4", 100,"clothes"),
        new Product("pivo5", 100,"clothes"),
        new Product("pivo6", 100,"foods")
    };
    public List<Tecnici> Tecnics = new List<Tecnici>()
    {
        /**/
    };
    public List<Product> Cloths = new List<Product>() { };
}