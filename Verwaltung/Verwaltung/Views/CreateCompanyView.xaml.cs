using System;
using System.Windows.Controls;
using Verwaltung.ViewModels;

namespace Verwaltung.Views
{
    /// <summary>
    ///     Interaction logic for CreateCustomerView.xaml
    /// </summary>
    public partial class CreateCompanyView : UserControl
    {
        public CreateCompanyView(Action navigateBack)
        {
            InitializeComponent();
            DataContext = new CreateCompanyViewModel(navigateBack);
        }
    }
}