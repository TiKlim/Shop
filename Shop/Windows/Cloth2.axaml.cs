using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Linq;

namespace Shop;

public partial class Cloth2 : Window
{
    public Cloth2()
    {
        InitializeComponent();
        SetData("clothes"); //Ссылка на метод листа; Добавляем тип продукта
        Back.Click += BackkOpen; //Метод к кнопке "Назад"
        Add.Click += AddForm; //Метод к кнопке "Добавить"
    }
    private void SetData(string type) //Метод листа
    {
        Clothes.ItemsSource = Helper.DataObj.Products.Where(x => x.Type == type).Select(x => new
        {
            x.Name, x.Price, x.Type
        });
    }
    private void BackkOpen(object? sender, RoutedEventArgs e) //Метод кнопки "Назад"
    {
        User2 user2 = new User2();
        user2.Show();
        this.Close();
    }
    private void AddForm(object? sender, RoutedEventArgs e) //Метод кнопки "Добавить"
    {
        Window1 w1 = new Window1();
        w1.Show();
        SetData("clothes");
    }
}