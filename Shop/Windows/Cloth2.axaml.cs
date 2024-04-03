﻿using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Linq;

namespace Shop;

public partial class Cloth2 : Window
{
    public Cloth2()
    {
        InitializeComponent();
        SetData();
        Back.Click += BackkOpen;
        Add.Click += AddForm;
    }
    private void SetData()
    {
        Computer.ItemsSource = Helper.DataObj.Products.Select(x => new
        {
            x.Name
        });
    }
    private void BackkOpen(object? sender, RoutedEventArgs e)
    {
        User2 user2 = new User2();
        user2.Show();
        this.Close();
    }
    private void AddForm(object? sender, RoutedEventArgs e)
    {
        Window1 w1 = new Window1();
        w1.Show();
        SetData();
    }
}