using System.Windows.Controls;
using Verwaltung.ViewModels;

namespace Verwaltung.Views
{
    /// <summary>
    ///     Interaction logic for CreateCustomerDeals.xaml
    /// </summary>
    public partial class CreateCustomerDealsView : UserControl
    {
        public CreateCustomerDealsView(string benutzername)
        {
            InitializeComponent();
            DataContext = new CreateCustomerDealsViewModel(benutzername);
        }
    }
}