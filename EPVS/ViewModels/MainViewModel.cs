using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reactive;
using System.Windows.Input;


namespace EPVS.ViewModels;

public class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!cc";



    public ObservableCollection<string> Items { get; } = new ObservableCollection<string>
    {
        "桌面",
        "下载",
        "文档",
        "c:/job"
    };

    

    

    private static void ExecuteItemClick(string item)
    {
        // 在这里处理单击事件
        Console.WriteLine($"Item clicked: {item}");
    }
}
