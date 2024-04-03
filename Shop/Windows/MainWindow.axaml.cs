using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Linq;
using System.Net.Http;

namespace Shop;

public partial class MainWindow : Window
{
  public MainWindow()
  {
    InitializeComponent();
    B1.Click += OpenForm;
    Admin.Click += AdminOpen;
  }

  private void OpenForm(object? sender, RoutedEventArgs e)
  {
    User user = new User();
    user.Show();
    this.Close();
  }
  private void AdminOpen(object? sender, RoutedEventArgs e)
  {
    User2 user2 = new User2();
    user2.Show();
    this.Close();
    //mainWindow.Close();
    
  }
}