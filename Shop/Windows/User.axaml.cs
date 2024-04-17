using Avalonia.Controls;
using Avalonia.Interactivity;

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
  }
  private void OpenForm2(object? sender, RoutedEventArgs e) //Метод для кнопки "Главная"
  {
    MainWindow window = new MainWindow();
    window.Show();
    this.Close();
  }
  private void OpenForm3(object? sender, RoutedEventArgs e) //Метод для карточки "Продукты"
  {
    Food food = new Food();
    food.Show();
    this.Close();
  }
  private void OpenForm6(object? sender, RoutedEventArgs e) //Метод для карточки "Техника"
  {
    Tecnic tecnic = new Tecnic();
    tecnic.Show();
    this.Close();
  }
  private void OpenForm7(object? sender, RoutedEventArgs e) //Метод для карточки "Одежда"
  {
    Cloth cloth = new Cloth();
    cloth.Show();
    this.Close();
  }
}