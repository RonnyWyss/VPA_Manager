using System;
using System.Windows.Controls;
using Verwaltung.ViewModels;

namespace Verwaltung.Views
{
    /// <summary>
    ///     Interaction logic for CreateCustomerView.xaml
    /// </summary>
    public partial class CreateCustomerView : UserControl
    {
        public CreateCustomerView(Action navigateBack)
        {
            InitializeComponent();
            DataContext = new CreateCustomerViewModel(navigateBack);
        }
    }
}