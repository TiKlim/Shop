using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using System;
using System.Linq;
using System.Net.Http;

namespace Shop;

public partial class Food2 : Window
{
    public Food2()
    {
        InitializeComponent();
        Backkk.Click += BacckOpen;
    }
    private void BacckOpen(object? sender, RoutedEventArgs e)
    {
        User2 user2 = new User2();
        user2.Show();
        this.Close();
    }
}