using System.Collections.Generic;

namespace Shop;

public class DataBase
{
    public List<Product> Products = new List<Product>()
    {
        new Product("Хлеб ржаной", 60,"foods"),
        new Product("Молоко 'Зойкина радость' 1 литр", 65,"foods"),
        new Product("Стиральная машина", 88600,"technic"),
        new Product("Тостер", 10288,"technic"),
        new Product("Рубашка клетчатая (красный/синий)", 1080,"clothes"),
        new Product("Джинсы JB (летние)", 2300,"clothes"),
        new Product("Кукурузные хлопья 'Хлопь и Я'", 196,"foods"),
        new Product("Телевизор 'LC' Smart TV", 93000, "technic"),
        new Product("Шапка с узором 'Русский орнамент'", 934, "clothes")
    };
}