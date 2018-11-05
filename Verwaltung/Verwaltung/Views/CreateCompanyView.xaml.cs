using System.Windows.Controls;
using Verwaltung.Services;
using Verwaltung.ViewModels;

namespace Verwaltung.Views
{
    /// <summary>
    ///     Interaction logic for CreateCustomerView.xaml
    /// </summary>
    public partial class CreateCompanyView : UserControl
    {
        public CreateCompanyView(string benutzername)
        {
            InitializeComponent();
            DataContext = new CreateCompanyViewModel(benutzername);
        }
    }
}