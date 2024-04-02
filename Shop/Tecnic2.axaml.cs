using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using System;
using System.Linq;
using System.Net.Http;

namespace Shop;

public partial class Tecnic2 : Window
{
    public Tecnic2()
    {
        InitializeComponent();
        Obratno.Click += ObratnoForm;
    }
    private void ObratnoForm(object? sender, RoutedEventArgs e)
    {
        User2 user2 = new User2();
        user2.Show();
        this.Close();
    }
}