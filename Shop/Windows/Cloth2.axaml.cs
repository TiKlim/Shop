using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Linq;
using Shop.Windows;

namespace Shop;

public partial class Cloth2 : Window
{
    public static int[] mas = new int[1];
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
        Basket.Click += ToBasketForm; //Метод к кнопке "Корзина"
    }
    private void SetData(string type) //Метод листа
    {
        Clothes.ItemsSource = Helper.DataObj.Products.Where(x => x.Type == type).OrderBy(x => x.Idd).Select(x => new
        {
            x.Name, 
            x.Price,
            x.Type, 
            x.Idd
        });
    }
    private void BackkOpen(object? sender, RoutedEventArgs e) //Метод кнопки "Назад"
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
    private void Foodbasket(object? sender, RoutedEventArgs e)
    {
        //Helper.DataObj.Basket.Add();
        /*for (int i = 0; i < Helper.DataObj.Products.Count; i++)
        {
            Helper.DataObj.Products[i].Idd = i;
            Helper.DataObj.Basket.InsertRange(i, Helper.DataObj.Products);
        }*/
        if (0 <= Helper.DataObj.Products.Count - 1)
        {
            //int i = Convert.ToInt16((Product)(sender as Button)!.Tag!);
            //Helper.DataObj.massiv[1]
            //mas[0] = i;
            Helper.DataObj.Basket.AddRange(Helper.DataObj.Products.Take(1)); //Take выбирает количество элментов с первого. Получить кокретный элемент не получилось. Take не работает с индексами
        }
        Clothes.ItemsSource = Helper.DataObj.Products.ToList();
        SetData("clothes");
        /*for (int i = 0; i < Helper.DataObj.Products.Count; i++)
        {
            Helper.DataObj.Products[i].Idd = i;
        }
        Clothes.ItemsSource = Helper.DataObj.Products.ToList();*/
        //Helper.DataObj.Basket.AddRange();
        //Helper.DataObj.Products.Add();
        /*foreach (var item in Helper.DataObj.Products)
        {
            Helper.DataObj.Basket.Add(item);
        }*/
        //int a = (int)(sender as Button)!.Tag!;
        //Helper.DataObj.Basket.Add(a);
        // Retrieve ProductID from the query string
        //string productId = Request.QueryString["ProductID"];
        // Add the product to the shopping cart
        //ShoppingCartBLO.AddItem(productId);
    }
    private void ToBasketForm(object? sender, RoutedEventArgs e) //Метод кнопки "Корзина"
    {
        Basket basket = new Basket(); //Storage
        basket.Show();
    }
}