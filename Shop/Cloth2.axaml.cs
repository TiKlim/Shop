using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using System;
using System.Linq;
using System.Net.Http;

namespace Shop;

public partial class Cloth2 : Window
{
    public Cloth2()
    {
        InitializeComponent();
        Back.Click += BackkOpen;
    }
    private void BackkOpen(object? sender, RoutedEventArgs e)
    {
        User2 user2 = new User2();
        user2.Show();
        this.Close();
    }
}