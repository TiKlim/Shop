using Avalonia.Controls;
using Avalonia.Interactivity;
using Shop.Windows;

namespace Shop;

public partial class User : Window
{
  public User()
  {
    InitializeComponent();
    Main.Click += OpenForm2; //Создание метода для кнопки "Главная"
    Product.Click += OpenForm3; //Создание метода для карточки "Продукты"
    Technic.Click += OpenForm6; //Создание метода для карточки "Техника"
    Clothes.Click += OpenForm7; //Создание метода для карточки "Одежда"
    Basket.Click += ToBasket; //Метод перехода в корзину
  }
  private void OpenForm2(object? sender, RoutedEventArgs e) //Метод для кнопки "Главная"
  {
    MainWindow window = new MainWindow();
    window.Show();
    Close();
  }
  private void OpenForm3(object? sender, RoutedEventArgs e) //Метод для карточки "Продукты"
  {
    Food food = new Food();
    food.Show();
    Close();
  }
  private void OpenForm6(object? sender, RoutedEventArgs e) //Метод для карточки "Техника"
  {
    Technic tecnic = new Technic();
    tecnic.Show();
    Close();
  }
  private void OpenForm7(object? sender, RoutedEventArgs e) //Метод для карточки "Одежда"
  {
    Cloth cloth = new Cloth();
    cloth.Show();
    Close();
  }
  private void ToBasket(object? sender, RoutedEventArgs e)
  {
    Basket basket = new Basket();
    basket.Show();
  }
}