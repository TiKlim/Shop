using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using System;
using System.Linq;
using System.Net.Http;

namespace Shop;

public partial class Food : Window
{
  public Food()
  {
    InitializeComponent();
    B5.Click += OpenForm4;
  }
  private void OpenForm4(object? sender, RoutedEventArgs e)
  {
    User user = new User();
    user.Show();
    this.Close();
  }
}