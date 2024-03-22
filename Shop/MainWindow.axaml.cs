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
  }

  private void OpenForm(object? sender, RoutedEventArgs e)
  {
    User user = new User();
    user.Show();
    this.Close();
    //mainWindow.Close();
    
  }
}