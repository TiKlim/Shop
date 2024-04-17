using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Linq;

namespace Shop;

public partial class Tecnic : Window
{
  public Tecnic()
  {
    InitializeComponent();
    SetData("technic"); //Ссылка на метод листа; Вписываем тип
    Back.Click += OpenBack; //Создаём метод для кнопки "Назад"
  }
  private void SetData(string type) //Метод листа
  {
    Technic.ItemsSource = Helper.DataObj.Products.Where(x => x.Type == type).Select(x => new
    {
      x.Name, x.Price, x.Type
    });
  }
  private void OpenBack(object? sender, RoutedEventArgs e) //Метод для кнопки "Назад"
  {
    User user = new User();
    user.Show();
    this.Close();
  }
}