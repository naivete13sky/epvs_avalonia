using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Markup.Xaml;
using EPVS.ViewModels;
using Avalonia.Interactivity;
using System;
using System.IO;
using System.Linq;

namespace EPVS.Views;

public partial class MainWindow : Window
{
    private ListBox _fileListBox;
    public MainWindow()
    {
        InitializeComponent();

        _fileListBox = this.FindControl<ListBox>("fileListBox");
        LoadFileList();

    }

    private void LoadFileList()
    {
        string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string[] files = Directory.GetFiles(directoryPath);

        foreach (string file in files)
        {
            _fileListBox.Items.Add(Path.GetFileName(file));
        }
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

