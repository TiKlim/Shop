﻿using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Linq;
using Shop.Windows;

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

    private void ClothBasket(object? sender, RoutedEventArgs e)
    {
        Helper.DataObj.Basket.Add(Helper.DataObj.Products[(int)(sender as Button)!.Tag!]);
    }
    
    private void ClothEditForm(object? sender, RoutedEventArgs e) //Метод кнопки "Редактировать"
    {
        int i = (int)(sender as Button)!.Tag!;
        Helper.Edit[0] = i;
        User2 u2 = new User2();
        u2.Show();
        Close();
        Window2 w2 = new Window2();
        w2.Show();
    }

    private void ToBasketForm(object? sender, RoutedEventArgs e) //Метод кнопки "Корзина"
    {
        Basket basket = new Basket(); //Storage
        basket.Show();
    }
}