using System.Windows.Controls;
using Verwaltung.ViewModels;

namespace Verwaltung.Views
{
    /// <summary>
    ///     Interaction logic for CreateCustomerRapportView.xaml
    /// </summary>
    public partial class CreateCustomerRapportView : UserControl
    {
        public CreateCustomerRapportView(string benutzer)
        {
            InitializeComponent();
            DataContext = new CreateCustomerRapportViewModel(benutzer);
        }
    }
}