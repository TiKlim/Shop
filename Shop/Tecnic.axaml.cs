using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using System;
using System.Linq;
using System.Net.Http;


namespace Shop;

public partial class Tecnic : Window
{
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public Tecnic(string firstName , string lastName)
  {
    FirstName = firstName;
    LastName = lastName;
    InitializeComponent();
    Back.Click += OpenForm5;
  }
  private void OpenForm5(object? sender, RoutedEventArgs e)
  {
    User user = new User();
    user.Show();
    this.Close();
  }
}