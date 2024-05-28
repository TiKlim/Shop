using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Linq;
using Shop.Windows;

namespace Shop;

public partial class Food2 : Window
{
    public Food2()
    {
        InitializeComponent();
        if (0 <= Helper.DataObj.Products.Count - 1)
        {
            for (int i = 0; i < Helper.DataObj.Products.Count; i++)
            {
                Helper.DataObj.Products[i].Idd = i;
            }
            Foods.ItemsSource = Helper.DataObj.Products.ToList();
        }
        SetData("foods"); //Ссылка на метод листа; Добавляем тип продукта
        Backkk.Click += BacckOpen; //Метод к кнопке "Назад"
        Add.Click += AddForm; //Метод к кнопке "Добавить"
        Basket.Click += ToBasketForm; //Метод к кнопке "Корзина"
    }
    private void SetData(string type) //Метод листа
    {
        Foods.ItemsSource = Helper.DataObj.Products.Where(x => x.Type == type).Select(x => new
        {
            x.Name, x.Price, x.Type, x.Idd
        });
    }
    private void BacckOpen(object? sender, RoutedEventArgs e) //Метод кнопки "Назад"
    {
        User2 user2 = new User2();
        user2.Show();
        Close();
    }
    private void AddForm(object? sender, RoutedEventArgs e) //Метод кнопки "Добавить"
    {
        User2 u2 = new User2();
        u2.Show();
        Close();
        Window1 w1 = new Window1();
        w1.Show();
        SetData("foods");
    }
    private void FoodRemoveForm(object? sender, RoutedEventArgs e) //Метод кнопки "Удалить"
    {
        if (0 <= Helper.DataObj.Products.Count - 1)
        {
            Helper.DataObj.Products.RemoveAt((int)(sender as Button)!.Tag!);
            for (int i = 0; i < Helper.DataObj.Products.Count; i++)
            {
                Helper.DataObj.Products[i].Idd = i;
            }
            Foods.ItemsSource = Helper.DataObj.Products.ToList();
        }
        SetData("foods");
    }
    
    private void FoodBasket(object? sender, RoutedEventArgs e)
    {
        Helper.DataObj.Basket.Add(Helper.DataObj.Products[(int)(sender as Button)!.Tag!]);
    }
    
    private void FoodEditForm(object? sender, RoutedEventArgs e) //Метод кнопки "Редактировать"
    {
        int i = (int)(sender as Button)!.Tag!;
        Helper.Edit[0] = i;
        Window2 w2 = new Window2();
        w2.Show();
    }
    
    private void ToBasketForm(object? sender, RoutedEventArgs e) //Метод кнопки "Корзина"
    {
        Basket basket = new Basket(); //Storage
        basket.Show();
    }
}