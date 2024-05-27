using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Linq;

namespace Shop.Windows;

public partial class Basket : Window
{
    public Basket()
    {
        InitializeComponent();
        if (0 <= Helper.DataObj.Basket.Count - 1)
        {
            for (int i = 0; i < Helper.DataObj.Basket.Count; i++)
            {
                Helper.DataObj.Basket[i].Idd = i;
            }
            Baskett.ItemsSource = Helper.DataObj.Basket.ToList();
        }
        SetData();
        Back.Click += MainForm;
    }
    private void SetData()
    {
        Baskett.ItemsSource = Helper.DataObj.Basket.OrderBy(x => x.Idd).Select(x => new
        {
            x.Name, x.Price, x.Type, x.Idd
        });
    }
    private void MainForm(object? sender, RoutedEventArgs e)
    {
        Close();
    }
    private void RemoveForm(object? sender, RoutedEventArgs e)
    {
        if (0 <= Helper.DataObj.Products.Count - 1)
        {
            Helper.DataObj.Basket.RemoveAt((int)(sender as Button)!.Tag!);
            for (int i = 0; i < Helper.DataObj.Basket.Count; i++)
            {
                Helper.DataObj.Basket[i].Idd = i;
            }
            Baskett.ItemsSource = Helper.DataObj.Basket.ToList();
        }
    }
}