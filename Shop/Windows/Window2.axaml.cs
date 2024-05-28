using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Collections.Generic;

namespace Shop.Windows;

public partial class Window2 : Window
{
    private List<Type> _types = new List<Type>() //Лист с типами по индексам и типам, им соответствующим
    {
        new Type(0, "Продукты питания"),
        new Type(1, "Техника"),
        new Type(2, "Одежда")
    };
    
    public Window2()
    {
        InitializeComponent();
        Edit.Click += EditForm; //Кнопка для метода добавления
        Price.Text = Convert.ToString(Helper.DataObj.Products[Helper.Edit[0]].Price);
        Name.Text = Helper.DataObj.Products[Helper.Edit[0]].Name;
    }
    
    private void EditForm(object? sender, RoutedEventArgs e) //Метод "Добавить"
    {
        EditProduct();
        Close();
    }

    private void EditProduct() //Метод создания продукта
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
        Helper.DataObj.Products[Helper.Edit[0]].Name = Name.Text;
        Helper.DataObj.Products[Helper.Edit[0]].Price = Convert.ToDouble(Price.Text);
        Helper.DataObj.Products[Helper.Edit[0]].Type = temp;
    }
}