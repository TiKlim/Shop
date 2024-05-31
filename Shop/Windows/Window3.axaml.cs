using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Shop.Windows;

public partial class Window3 : Window
{
    public Window3()
    {
        InitializeComponent();
        Return.Click += ReturnOnClick;
    }

    private void ReturnOnClick(object? sender, RoutedEventArgs e)
    {
        Close();
        MainWindow mw = new MainWindow();
        mw.Show();
    }
}