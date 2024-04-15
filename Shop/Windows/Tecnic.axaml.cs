using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Linq;

namespace Shop;

public partial class Tecnic : Window
{
  public Tecnic()
  {
    InitializeComponent();
    SetData("technic");
    Back.Click += OpenForm5;
  }
  private void SetData(string type)
  {
    Technic.ItemsSource = Helper.DataObj.Products.Where(x => x.Type == type).Select(x => new
    {
      x.Name, x.Price, x.Type
    });
  }
  private void OpenForm5(object? sender, RoutedEventArgs e)
  {
    User user = new User();
    user.Show();
    this.Close();
  }
}