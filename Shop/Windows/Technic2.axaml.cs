﻿using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Linq;

namespace Shop;

public partial class Technic2 : Window
{
    public Technic2()
    {
        InitializeComponent();
        if (0 <= Helper.DataObj.Products.Count - 1)
        {
            for (int i = 0; i < Helper.DataObj.Products.Count; i++)
            {
                Helper.DataObj.Products[i].Idd = i;
            }
            Technics.ItemsSource = Helper.DataObj.Products.ToList();
        }
        SetData("technic"); //Ссылка на метод листа; Добавляем тип продукта
        Obratno.Click += ObratnoForm; //Метод к кнопке "Назад"
        Add.Click += AddForm; //Метод к кнопке "Добавить"
    }

    private void SetData(string type) //Метод листа
    {
        Technics.ItemsSource = Helper.DataObj.Products.Where(x => x.Type == type).Select(x => new
        {
            x.Name, x.Price, x.Type, x.Idd
        });
    }

    private void ObratnoForm(object? sender, RoutedEventArgs e) //Метод кнопки "Назад"
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
        SetData("technic");
    }
    private void TechRemoveForm(object? sender, RoutedEventArgs e) //Метод кнопки "Удалить"
    {
        if (0 <= Helper.DataObj.Products.Count - 1)
        {
            Helper.DataObj.Products.RemoveAt((int)(sender as Button)!.Tag!);
            for (int i = 0; i < Helper.DataObj.Products.Count; i++)
            {
                Helper.DataObj.Products[i].Idd = i;
            }
            Technics.ItemsSource = Helper.DataObj.Products.ToList();
        }
        SetData("technic");
    }
}