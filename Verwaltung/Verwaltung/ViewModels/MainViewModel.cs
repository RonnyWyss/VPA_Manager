using System.Windows.Controls;
using Prism.Commands;
using Prism.Mvvm;
using Verwaltung.Views;

namespace Verwaltung.ViewModels
{
    internal class MainViewModel : BindableBase
    {
        private string _benutzer;

        private UserControl _content;

        public MainViewModel(string benutzername)
        {
            Benutzer = benutzername;
            CmdNavigateToSearch = new DelegateCommand(OnCmdNavigateToSearch);
            CmdNavigateToDocumentDetail = new DelegateCommand(OnCmdNavigateToDocumentDetail);
            CmdNavigateToCreateCompany = new DelegateCommand(OnCmdNavigateToCreateCompany);
            CmdNavigateToCreateCustomer = new DelegateCommand(OnCmdNavigateToCreateCustomer);
            CmdNavigateToCreateCustomerRapport = new DelegateCommand(OnCmdNavigateToCreateCustomerRapport);
        }

        public string Benutzer
        {
            get => _benutzer;

            set => SetProperty(ref _benutzer, value);
        }

        public UserControl Content
        {
            get => _content;

            set => SetProperty(ref _content, value);
        }

        public DelegateCommand CmdNavigateToSearch { get; }

        public DelegateCommand CmdNavigateToDocumentDetail { get; }

        public DelegateCommand CmdNavigateToCreateCustomer { get; }

        public DelegateCommand CmdNavigateToCreateCompany { get; }

        public DelegateCommand CmdNavigateToCreateCustomerRapport { get; }

        private void OnCmdNavigateToSearch()
        {
            NavigateToSearch();
        }

        private void OnCmdNavigateToDocumentDetail()
        {
            //   Content = new DocumentDetailView(Benutzer, NavigateToSearch);
        }

        private void NavigateToSearch()
        {
            //    Content = new SearchView();
        }

        private void OnCmdNavigateToCreateCompany()
        {
            Content = new CreateCompanyView(NavigateToSearch);
        }

        private void OnCmdNavigateToCreateCustomer()
        {
            Content = new CreateCustomerView(NavigateToSearch);
        }

        private void OnCmdNavigateToCreateCustomerRapport()
        {
            Content = new CreateCustomerRapportView(Benutzer);
        }
    }
}