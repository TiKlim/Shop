using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using System;
using System.Linq;
using System.Net.Http;

namespace Shop;

public partial class User : Window
{
  public User()
  {
    InitializeComponent();
    B3.Click += OpenForm2;
    B6.Click += OpenForm3;
  }
  private void OpenForm2(object? sender, RoutedEventArgs e)
  {
    MainWindow window = new MainWindow();
    window.Show();
    this.Close();
  }
  private void OpenForm3(object? sender, RoutedEventArgs e)
  {
    Food food = new Food();
    food.Show();
    this.Close();
  }
}