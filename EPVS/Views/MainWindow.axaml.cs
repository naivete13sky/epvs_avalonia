using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
namespace EPVS.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }



    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }



    private void ShowPopupOnClick(object sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        // 创建一个弹窗
        var dialog = new Window
        {
            Title = "后退弹窗",
            Content = new TextBlock
            {
                Text = "后退按钮被点击！",
                FontSize = 16,
                HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center,
            },
            Width = 300,
            Height = 200,
        };

        // 显示弹窗
        dialog.ShowDialog(this);
    }

}

