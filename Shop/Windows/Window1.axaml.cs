using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Collections.Generic;

namespace Shop;

public partial class Window1 : Window
{
    private List<Type> _types = new List<Type>() //Лист с типами по индексам и типам, им соответствующим
    {
        new Type(0, "Продукты питания"),
        new Type(1, "Техника"),
        new Type(2, "Одежда")
    };
    
    public Window1()
    {
        InitializeComponent();
        Dob.Click += DobForm; //Кнопка для метода добавления 
    }
    
    private void DobForm(object? sender, RoutedEventArgs e) //Метод "Добавить"
    {
        CreateProduct();
        Close();
        Cloth2 c2 = new Cloth2();
        c2.Show();
        c2.Close();
    }

    private void CreateProduct() //Метод создания продукта
    {
        string temp = " ";
        switch (Type.SelectedIndex) //Изходя из того, что выбрал пользователь выбираем тип продукта
        {
            case 0: temp = "foods"; 
                break;
            case 1: temp = "technic"; 
                break;
            case 2: temp = "clothes";
                break;
        }
        Helper.DataObj.Products.Add(new Product(Name.Text!, Convert.ToDouble(Price.Text), temp, 0));
    }
}