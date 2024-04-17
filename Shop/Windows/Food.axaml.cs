using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Linq;

namespace Shop;

public partial class Food : Window
{
  public Food()
  {
    InitializeComponent();
    SetData("foods"); //Ссылка на метод листа; вписываем тип продукта
    Baccck.Click += OpenForm4;
  }
  private void SetData(string type) //Метод листа
  {
    Foods.ItemsSource = Helper.DataObj.Products.Where(x => x.Type == type).Select(x => new
    {
      x.Name, x.Price, x.Type
    });
  }
  private void OpenForm4(object? sender, RoutedEventArgs e) //Метод для кнопки "Назад"
  {
    User user = new User();
    user.Show();
    this.Close();
  }
}