using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Linq;

namespace Shop.Windows;

public partial class Basket : Window
{
    public Basket()
    {
        InitializeComponent();
        if (0 <= Helper.DataObj.Products.Count - 1)
        {
            for (int i = 0; i < Helper.DataObj.Products.Count; i++)
            {
                Helper.DataObj.Products[i].Idd = i;
            }
            Baskett.ItemsSource = Helper.DataObj.Basket.ToList();
        }
        //Baskett.ItemsSource = Helper.DataObj.Products.ToList();
        SetData();
        Back.Click += MainForm;
    }
    private void SetData()
    {
        /*Baskett.ItemsSource = Helper.DataObj.Basket.Select(x => new
        {
            x.Name, x.Price, x.Type
        });*/
        Baskett.ItemsSource = Helper.DataObj.Products.OrderBy(x => x.Idd).Select(x => new
        {
            x.Name, x.Price, x.Type, x.Idd
        });
    }
    private void MainForm(object? sender, RoutedEventArgs e)
    {
        Close();
    }
}