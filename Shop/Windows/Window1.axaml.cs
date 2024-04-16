using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Collections.Generic;

namespace Shop;

public partial class Window1 : Window
{
    private List<Product> goods;

    private Food2 _food2 = new Food2();
    private List<Type> _types = new List<Type>()
    {
        new Type(0, "Продукты питания"),
        new Type(1, "Техника"),
        new Type(2, "Одежда")
    };
    
    public Window1()
    {
        InitializeComponent();
        Dob.Click += DobForm;
    }
    
    private void DobForm(object? sender, RoutedEventArgs e)
    {
        CreateProduct();
        Close();
    }

    private void CreateProduct()
    {
        string temp = " ";

        switch (Type.SelectedIndex)
        {
            case 0: temp = "foods"; 
                break;
            case 1: temp = "technic"; 
                break;
            case 2: temp = "clothes";
                break;
        }
        Helper.DataObj.Products.Add( new Product(Name.Text!, Convert.ToDouble(Price.Text),temp));
    }
}