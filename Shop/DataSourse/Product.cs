namespace Shop;

public class Product
{
    private string nameProduct;
    private double priceProduct;
    private string typeProduct;
    //private int idProduct;
    public Product(string name, double price, string type)
    {
        nameProduct = name;
        priceProduct = price;
        typeProduct = type;
        //idProduct = id;
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

    /*public int Id
    {
        get { return idProduct; }
        set { idProduct = value; }
    }*/
}