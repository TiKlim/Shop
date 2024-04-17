using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Shop;

public partial class MainWindow : Window
{
  public MainWindow()
  {
    InitializeComponent();
    Guest.Click += GuestForm; //Создание метода для кнопки "Гость"
    Admin.Click += AdminOpen; //Создание метода для кнопки "Админ"
  }

  private void GuestForm(object? sender, RoutedEventArgs e) //Метод для кнопки "Гость"
  {
    User user = new User();
    user.Show();
    this.Close();
  }
  private void AdminOpen(object? sender, RoutedEventArgs e) //Метод для кнопки "Админ"
  {
    User2 user2 = new User2();
    user2.Show();
    this.Close();
  }
}