using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Linq;

namespace Shop;

public partial class Tecnic2 : Window
{
    public Tecnic2()
    {
        InitializeComponent();
        SetData("technic");
        Obratno.Click += ObratnoForm;
        Add.Click += AddForm;
    }

    private void SetData(string type)
    {
        Technic.ItemsSource = Helper.DataObj.Products.Where(x => x.Type == type).Select(x => new
        {
            x.Name, x.Price, x.Type
        });
    }

    private void ObratnoForm(object? sender, RoutedEventArgs e)
    {
        User2 user2 = new User2();
        user2.Show();
        this.Close();
    }
    private void AddForm(object? sender, RoutedEventArgs e)
    {
        Window1 w1 = new Window1();
        w1.Show();
        SetData("technic");
    }
}