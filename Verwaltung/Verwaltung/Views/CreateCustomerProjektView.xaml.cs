using System.Windows.Controls;
using Verwaltung.ViewModels;

namespace Verwaltung.Views
{
    /// <summary>
    ///     Interaction logic for CreateCustomerProjekt.xaml
    /// </summary>
    public partial class CreateCustomerProjektView : UserControl
    {
        public CreateCustomerProjektView(string benutzername)
        {
            InitializeComponent();
            DataContext = new CreateCustomerProjektViewModel(benutzername);
        }
    }
}