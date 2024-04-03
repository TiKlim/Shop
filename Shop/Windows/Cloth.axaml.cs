using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using System;
using System.Linq;
using System.Net.Http;

namespace Shop;

public partial class Cloth : Window
{
  public Cloth()
  {
    InitializeComponent();
    Back.Click += OpenForm8;
  }
  private void OpenForm8(object? sender, RoutedEventArgs e)
  {
    User user = new User();
    user.Show();
    this.Close();
  }
}