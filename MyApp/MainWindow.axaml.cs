using Avalonia.Controls;
using Avalonia.Interactivity;

namespace MyApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new ConverterViewModel();
    }

    

}