using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Linq;

namespace Shop;

public partial class Food2 : Window
{
    public Food2()
    {
        InitializeComponent();
        SetData();
        Backkk.Click += BacckOpen;
        Add.Click += AddForm;
    }
    private void SetData()
    {
        Computer.ItemsSource = Helper.DataObj.Products.Select(x => new
        {
            x.Name
        });
    }
    private void BacckOpen(object? sender, RoutedEventArgs e)
    {
        User2 user2 = new User2();
        user2.Show();
        this.Close();
    }
    private void AddForm(object? sender, RoutedEventArgs e)
    {
        Window1 w1 = new Window1();
        w1.Show();
        SetData();
    }
}