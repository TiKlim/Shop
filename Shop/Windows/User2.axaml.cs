using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using System;
using System.Linq;
using System.Net.Http;

namespace Shop;

public partial class User2 : Window
{
    public User2()
    {
        InitializeComponent();
        Backk.Click += BackOpen;
        Products.Click += FoodOpen;
        Tecnic.Click += TecOpen;
        Clothes.Click += ClothOpen;
    }
    private void BackOpen(object? sender, RoutedEventArgs e)
    {
        MainWindow window = new MainWindow();
        window.Show();
        this.Close();
    }
    private void FoodOpen(object? sender, RoutedEventArgs e)
    {
        Food2 food2 = new Food2();
        food2.Show();
        this.Close();
    }
    private void TecOpen(object? sender, RoutedEventArgs e)
    {
        Tecnic2 tecnic2 = new Tecnic2();
        tecnic2.Show();
        this.Close();
    }
    private void ClothOpen(object? sender, RoutedEventArgs e)
    {
        Cloth2 cloth2 = new Cloth2();
        cloth2.Show();
        this.Close();
    }
}