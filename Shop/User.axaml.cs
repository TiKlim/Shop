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
    B7.Click += OpenForm6;
    B8.Click += OpenForm7;
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
  private void OpenForm6(object? sender, RoutedEventArgs e)
  {
    Tecnic tecnic = new Tecnic(firstName, lastName);
    tecnic.Show();
    this.Close();
  }
  private void OpenForm7(object? sender, RoutedEventArgs e)
  {
    Cloth cloth = new Cloth();
    cloth.Show();
    this.Close();
  }
}