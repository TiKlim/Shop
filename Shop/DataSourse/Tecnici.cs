namespace Shop;

public class Tecnici
{
    private string nameTecnic;
    private double priceTecnic;
    private string typeTecnic;
    public Tecnici(string name, double price, string type)
    {
        nameTecnic = name;
        priceTecnic = price;
        typeTecnic = type;
    }
    public string Name2
    {
        get { return nameTecnic;}
        set { nameTecnic = value; }
    }
    public double Price2
    {
        get { return priceTecnic; }
        set { priceTecnic = value; }
    }
    public string Type2
    {
        get { return typeTecnic; }
        set { typeTecnic = value; }
    }
}