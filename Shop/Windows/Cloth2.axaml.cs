using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.Generic;
using System.Linq;

namespace Shop;

public partial class Cloth2 : Window
{
    public Cloth2()
    {
        InitializeComponent();
        if (0 <= Helper.DataObj.Products.Count - 1)
        {
            for (int i = 0; i < Helper.DataObj.Products.Count; i++)
            {
                Helper.DataObj.Products[i].Idd = i;
            }
            Clothes.ItemsSource = Helper.DataObj.Products.ToList();
        }
        SetData("clothes"); //Ссылка на метод листа; Добавляем тип продукта
        Back.Click += BackkOpen; //Метод к кнопке "Назад"
        Add.Click += AddForm; //Метод к кнопке "Добавить"
    }
    private void SetData(string type) //Метод листа
    {
        Clothes.ItemsSource = Helper.DataObj.Products.Where(x => x.Type == type).OrderBy(x => x.Idd).Select(x => new
        {
            x.Name, x.Price, x.Type, x.Idd
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
    private void RemoveForm(object? sender, RoutedEventArgs e) //Метод кнопки "Удалить"
    {
        if (0 <= Helper.DataObj.Products.Count - 1)
        {
            Helper.DataObj.Products.RemoveAt((int)(sender as Button)!.Tag!);
            for (int i = 0; i < Helper.DataObj.Products.Count; i++)
            {
                Helper.DataObj.Products[i].Idd = i;
            }
            Clothes.ItemsSource = Helper.DataObj.Products.ToList();
        }
        SetData("clothes");
    }
}