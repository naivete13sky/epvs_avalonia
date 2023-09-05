using System.Collections.ObjectModel;
using System.ComponentModel;

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
}
