﻿using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Linq;

namespace Shop;

public partial class Tecnic2 : Window
{
    public Tecnic2()
    {
        InitializeComponent();
        SetData();
        Obratno.Click += ObratnoForm;
        Add.Click += AddForm;
    }

    private void SetData()
    {
        Computer.ItemsSource = Helper.DataObj2.Tecnics.Select(x => new
        {
            x.Name2
        });
    }

    private void ObratnoForm(object? sender, RoutedEventArgs e)
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