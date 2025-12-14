using Microsoft.UI.Xaml.Controls;

using WinUITemplateStudio.ViewModels;

namespace WinUITemplateStudio.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
