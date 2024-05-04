using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Shop;

public partial class User2 : Window
{
    public User2()
    {
        InitializeComponent();
        Backk.Click += BackOpen; //Создаём метод для кнопки "Назад"
        Products.Click += FoodOpen; //Создаём метод для карточки "Продукты"
        Technic.Click += TecOpen; //Создаём метод для карточки "Техника"
        Clothes.Click += ClothOpen; //Создаём метод для карточки "Одежда"
    }
    private void BackOpen(object? sender, RoutedEventArgs e) //Метод для кнопки "Назад"
    {
        MainWindow window = new MainWindow();
        window.Show();
        this.Close();
    }
    private void FoodOpen(object? sender, RoutedEventArgs e) //Метод для карточки "Продукты"
    {
        Food2 food2 = new Food2();
        food2.Show();
        this.Close();
    }
    private void TecOpen(object? sender, RoutedEventArgs e) //Метод для карточки "Техника"
    {
        Technic2 tecnic2 = new Technic2();
        tecnic2.Show();
        this.Close();
    }
    private void ClothOpen(object? sender, RoutedEventArgs e) //Метод для карточки "Одежда"
    {
        Cloth2 cloth2 = new Cloth2();
        cloth2.Show();
        this.Close();
    }
}