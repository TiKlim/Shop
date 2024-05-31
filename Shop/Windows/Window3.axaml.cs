using Avalonia.Controls;
using Avalonia.Interactivity;

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
    }
}