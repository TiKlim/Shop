using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Linq;

namespace Shop;

public partial class Food2 : Window
{
    public Food2()
    {
        InitializeComponent();
        SetData("foods"); //Ссылка на метод листа; Добавляем тип продукта
        Backkk.Click += BacckOpen; //Метод к кнопке "Назад"
        Add.Click += AddForm; //Метод к кнопке "Добавить"
    }
    private void SetData(string type) //Метод листа
    {
        Foods.ItemsSource = Helper.DataObj.Products.Where(x => x.Type == type).Select(x => new
        {
            x.Name, x.Price, x.Type
        });
    }
    private void BacckOpen(object? sender, RoutedEventArgs e) //Метод кнопки "Назад"
    {
        User2 user2 = new User2();
        user2.Show();
        this.Close();
    }
    private void AddForm(object? sender, RoutedEventArgs e) //Метод кнопки "Добавить"
    {
        Window1 w1 = new Window1();
        w1.Show();
        SetData("foods");
    }
}