using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Collections.Generic;
using System.Linq;

namespace Shop;

public partial class Cloth2 : Window
{
    //private List<Product> Clothes1 = new();
    public Cloth2()
    {
        InitializeComponent();
        SetData("clothes"); //Ссылка на метод листа; Добавляем тип продукта
        Back.Click += BackkOpen; //Метод к кнопке "Назад"
        Add.Click += AddForm; //Метод к кнопке "Добавить"
        Remove.Click += RemoveForm; //Метод к кнопке "Удалить"
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
    private void RemoveForm(object? sender, RoutedEventArgs e) //Метод кнопки "Удалить"
    {
        //Window1 w1 = new Window1();
        //w1.Show();
        //SetData("clothes");
        //string temp = "clothes";
        //Helper.DataObj.Products.Remove( new Product(Name.Text!, Convert.ToDouble(Price.Text),temp));
        //ListBox.SelectObjectCollection selectedItems = new ListBox.SelectObjectCollection(Clothes);
            //Clothes.Items.Remove(Clothes.Items[1]);
        Clothes.Items.Clear();
        SetData("clothes");
        /*if (0 <= Clothes1.Count - 1)
        {
            Clothes1.RemoveAt((int)(sender as Button)!.Tag!);
            for (int i = 0; i < Clothes1.Count; i++)
            {
                Clothes1[i].Id = i;
            }
            SetData("clothes");
        }*/
    }
}