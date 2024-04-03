namespace Shop;

public class Product
{
    private string nameProduct;
    private double priceProduct;
    public Product(string name, double price)
    {
        nameProduct = name;
        priceProduct = price;
    }
    public string Name
    {
        get { return nameProduct;}
        set { nameProduct = value; }
    }
    public double Price
    {
        get { return priceProduct; }
        set { priceProduct = value; }
    }
}