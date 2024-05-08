using System.Collections.Generic;

namespace Shop;

public class DataBase
{
    public List<Product> Products = new List<Product>()
    {
        new Product("Хлеб ржаной", 60, "foods", 0),
        new Product("Молоко 'Зойкина радость' 1 литр", 65, "foods", 1),
        new Product("Стиральная машина", 88600, "technic", 2),
        new Product("Тостер", 10288, "technic", 3),
        new Product("Рубашка клетчатая (красный/синий)", 1080, "clothes", 4),
        new Product("Джинсы JB (летние)", 2300, "clothes", 5),
        new Product("Кукурузные хлопья 'Хлопь и Я'", 196, "foods", 6),
        new Product("Телевизор 'LC' Smart TV", 93000, "technic", 7),
        new Product("Шапка с узором 'Русский орнамент'", 934, "clothes", 8)
    };

    public List<Product> Basket = new List<Product>() { };
}