namespace Shop;

public class Product
{
    private string nameProduct;
    private double priceProduct;
    private string typeProduct;
    public Product(string name, double price, string type)
    {
        nameProduct = name;
        priceProduct = price;
        typeProduct = type;
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
    public string Type
    {
        get { return typeProduct; }
        set { typeProduct = value; }
    }
}