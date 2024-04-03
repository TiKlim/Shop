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
    private List<Window1> Computer;
    protected string name;
    protected double price;

    public Window1()
    {
        InitializeComponent();
        Dob.Click += DobForm;
        Info(Computer);
    }
    private void DobForm(object? sender, RoutedEventArgs e)
    {
        Computer.Add(new Window1());
        this.Close();
    }

    private void Info(List<Window1> Computer)
    {
        this.name = Name.Text;
        this.price = Convert.ToInt32(Price.Text);
    }
}