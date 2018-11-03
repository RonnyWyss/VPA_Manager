using System.Windows;
using Verwaltung.ViewModels;

namespace Verwaltung
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView(string benutzername)
        {
            InitializeComponent();
            DataContext = new MainViewModel(benutzername);
        }
    }
}