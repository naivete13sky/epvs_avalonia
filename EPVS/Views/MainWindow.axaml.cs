using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Markup.Xaml;
using EPVS.ViewModels;
using Avalonia.Interactivity;
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EPVS.Views;

public class FileItem
{
    public string Name { get; set; }
    public string Icon { get; set; }
}



public partial class MainWindow : Window
{
    private ListBox _fileListBox;
    public MainWindow()
    {
        InitializeComponent();

        _fileListBox = this.FindControl<ListBox>("fileListBox");
        
        //LoadFileList();
        //LoadFileSystemEntries();
        LoadFileList3();

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

    private void LoadFileSystemEntries()
    {
        string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string[] fileSystemEntries = Directory.GetFileSystemEntries(directoryPath);

        foreach (string entry in fileSystemEntries)
        {
            _fileListBox.Items.Add(Path.GetFileName(entry));
        }
    }

    private void LoadFileList2()
    {
        string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string[] fileSystemEntries = Directory.GetFileSystemEntries(directoryPath);

        List<FileItem> items = new List<FileItem>();

        foreach (string entry in fileSystemEntries)
        {
            FileItem item = new FileItem
            {
                Name = Path.GetFileName(entry),
                Icon = entry.EndsWith(Path.DirectorySeparatorChar.ToString()) ? "1.png" : "1.png" // 根据是文件还是文件夹设置图标路径
            };
            items.Add(item);
        }

        // 清空ListBox中的项
        _fileListBox.Items.Clear();

        // 将项添加到ListBox中
        foreach (var item in items)
        {
            _fileListBox.Items.Add(item);
        }
    }


    private void LoadFileList3()
    {
        string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string[] fileSystemEntries = Directory.GetFileSystemEntries(directoryPath);

        List<FileItem> items = new List<FileItem>();

        foreach (string entry in fileSystemEntries)
        {
            FileItem item = new FileItem
            {
                Name = Path.GetFileName(entry),
                Icon = entry.EndsWith(Path.DirectorySeparatorChar.ToString()) ? "1.png" : "1.png" // 根据是文件还是文件夹设置图标路径
            };

            _fileListBox.Items.Add(item);
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



    private void OnItemClicked(object sender, RoutedEventArgs e)
    {
        Button clickedButton = sender as Button;
        if (clickedButton != null)
        {
            string selectedItem = clickedButton.Content.ToString();

            // 在这里执行单击事件的处理逻辑，可以使用 selectedItem 变量来获取选中的项目的值            

            // 创建一个弹窗
            var dialog = new Window
            {
                Title = "后退弹窗",
                Content = new TextBlock
                {
                    Text = selectedItem,
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


}

