using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Shop;

public partial class Window1 : Window
{
    private List<Product> goods;
    //protected string name;
    //protected double price;

    public Window1()
    {
        InitializeComponent();
        Dob.Click += DobForm;
    }
    private void DobForm(object? sender, RoutedEventArgs e)
    {
        Helper.DataObj.Products.Add(new Product(Name.Text!, Convert.ToDouble(Price.Text)));
        Close();
    }

    /*private void Info(List<Window1> Computer)
    {
        this.name = Name.Text;
        this.price = Convert.ToInt32(Price.Text);
    }*/
}