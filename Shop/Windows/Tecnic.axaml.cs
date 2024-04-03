using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Shop;

public partial class Tecnic : Window
{
  //private List<Tecnic> Computer = new List<Tecnic>();
  public Tecnic()
  {
    InitializeComponent();
    Computer.ItemsSource = new List<Window1>();
    //Computer.ItemsSource = new string[] {"Компьютерная мышь", "Клавиатура", "Дисплей", "Блок питания", "Материнская плата", "Наушники"}.OrderBy(x => x);
    //Home.ItemsSource = new string[] {"Стиральная машина", "Тостер", "Телевизор", "Холодильник", "Утюг", "Кофемашина"}.OrderBy(x => x);
    Back.Click += OpenForm5;
    
  }
  private void OpenForm5(object? sender, RoutedEventArgs e)
  {
    User user = new User();
    user.Show();
    this.Close();
  }
}