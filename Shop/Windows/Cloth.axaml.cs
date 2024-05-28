using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Linq;

namespace Shop;

public partial class Cloth : Window
{
  public Cloth()
  {
    InitializeComponent();
    SetData("clothes");
    Back.Click += OpenForm8;
  }
  private void SetData(string type)
  {
    Clothes.ItemsSource = Helper.DataObj.Products.Where(x => x.Type == type).Select(x => new
    {
      x.Name, x.Price, x.Type
    });
  }
  private void OpenForm8(object? sender, RoutedEventArgs e)
  {
    User user = new User();
    user.Show();
    this.Close();
  }
  
  private void UserBasket(object? sender, RoutedEventArgs e) //Метод кнопки "Добавить в корзину"
  {
    Helper.DataObj.Basket.Add(Helper.DataObj.Products[(int)(sender as Button)!.Tag!]);
  }
}