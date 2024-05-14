using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace Combinaciones;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
        N1Box = this.FindControl<TextBox>("N1Box");
        N2Box = this.FindControl<TextBox>("N2Box");
        ActionButton = this.FindControl<Button>("ActionButton");
        ResultLabel = this.FindControl<Label>("ResultLabel");
    }

    private void ActionButton_OnClick(object? sender, RoutedEventArgs e)
    {
        int n, combinaciones, r;
        n = Convert.ToInt32(N1Box.Text);
        r = Convert.ToInt32(N2Box.Text);
        combinaciones = Factorial(n) / Factorial(r) * Factorial(n - r);
        ResultLabel.Content = combinaciones;
    }

    private int Factorial(int n)
    {
        int i, fact = 1;
        for (i = 1; i <= n; i++)
        {
            fact *= i;
        }
        return fact;
    }
}