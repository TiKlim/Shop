using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Linq;
using Shop.Windows;

namespace Shop;

public partial class Technic : Window
{
  public Technic()
  {
    InitializeComponent();
    SetData("technic"); //Ссылка на метод листа; Вписываем тип
    Back.Click += OpenBack; //Создаём метод для кнопки "Назад"
    Basket.Click += ToBasket; //Метод перехода в корзину
  }
  private void SetData(string type) //Метод листа
  {
    Technics.ItemsSource = Helper.DataObj.Products.Where(x => x.Type == type).Select(x => new
    {
      x.Name, x.Price, x.Type
    });
  }
  private void OpenBack(object? sender, RoutedEventArgs e) //Метод для кнопки "Назад"
  {
    User user = new User();
    user.Show();
    Close();
  }
  private void UserBasket(object? sender, RoutedEventArgs e) //Метод кнопки "Добавить в корзину"
  {
    Helper.DataObj.Basket.Add(Helper.DataObj.Products[(int)(sender as Button)!.Tag!]);
  }
  private void ToBasket(object? sender, RoutedEventArgs e)
  {
    Basket basket = new Basket();
    basket.Show();
  }
}