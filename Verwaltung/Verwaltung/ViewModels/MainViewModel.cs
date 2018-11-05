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
            CmdNavigateToCreateCompany = new DelegateCommand(OnCmdNavigateToCreateCompany);
            CmdNavigateToCreateCustomer = new DelegateCommand(OnCmdNavigateToCreateCustomer);
            CmdNavigateToCreateCustomerProjekt = new DelegateCommand(OnCmdNavigateToCreateCustomerProjekt);
            CmdNavigateToCreateCustomerDeals = new DelegateCommand(OnCmdNavigateToCreateCustomerDeals);
            CmdNavigateToCreateCustomerRapport = new DelegateCommand(OnCmdNavigateToCreateCustomerRapport);
            CmdNavigateToCreateCustomerContract = new DelegateCommand(OnCmdNavigateToCreateCustomerContract);
            CmdNavigateToCreateCustomerDelivery = new DelegateCommand(OnCmdNavigateToCreateCustomerDelivery);
            CmdNavigateToCreateHardware = new DelegateCommand(OnCmdNavigateToCreateHardware);
            CmdNavigateToCreateSoftware = new DelegateCommand(OnCmdNavigateToCreateSoftware);
            CmdNavigateToCreateInvoice = new DelegateCommand(OnCmdNavigateToCreateInvoice);
            CmdNavigateToCreateManufacturer = new DelegateCommand(OnCmdNavigateToCreateManufacturer);
            CmdNavigateToCreateOrder = new DelegateCommand(OnCmdNavigateToCreateOrder);
            CmdNavigateToCreateService = new DelegateCommand(OnCmdNavigateToCreateService);
            CmdNavigateToCreateSupplier = new DelegateCommand(OnCmdNavigateToCreateSupplier);
            CmdNavigateToCreateTicket = new DelegateCommand(OnCmdNavigateToCreateTicket);
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
        public DelegateCommand CmdNavigateToCreateCustomer { get; }
        public DelegateCommand CmdNavigateToCreateCompany { get; }
        public DelegateCommand CmdNavigateToCreateCustomerProjekt { get; }
        public DelegateCommand CmdNavigateToCreateCustomerDeals { get; }
        public DelegateCommand CmdNavigateToCreateCustomerRapport { get; }
        public DelegateCommand CmdNavigateToCreateCustomerContract { get; }
        public DelegateCommand CmdNavigateToCreateCustomerDelivery { get; }
        public DelegateCommand CmdNavigateToCreateHardware { get; }
        public DelegateCommand CmdNavigateToCreateSoftware { get; }
        public DelegateCommand CmdNavigateToCreateInvoice { get; }
        public DelegateCommand CmdNavigateToCreateManufacturer { get; }
        public DelegateCommand CmdNavigateToCreateOrder { get; }
        public DelegateCommand CmdNavigateToCreateService { get; }

        public DelegateCommand CmdNavigateToCreateSupplier { get; }
        public DelegateCommand CmdNavigateToCreateTicket { get; }


        private void OnCmdNavigateToSearch()
        {
            NavigateToSearch();
        }

        private void NavigateToSearch()
        {
            //    Content = new SearchView();
        }

        private void OnCmdNavigateToCreateCustomerContract()
        {
            Content = new CreateCustomerContractView();
        }

        private void OnCmdNavigateToCreateCompany()
        {
            Content = new CreateCompanyView(Benutzer);
        }

        private void OnCmdNavigateToCreateCustomer()
        {
            Content = new CreateCustomerView(Benutzer);
        }

        private void OnCmdNavigateToCreateCustomerProjekt()
        {
            Content = new CreateCustomerProjektView(Benutzer);
        }

        private void OnCmdNavigateToCreateCustomerDeals()
        {
            Content = new CreateCustomerDealsView(Benutzer);
        }

        private void OnCmdNavigateToCreateCustomerRapport()
        {
            Content = new CreateCustomerRapportView(Benutzer);
        }

        private void OnCmdNavigateToCreateCustomerDelivery()
        {
            Content = new CreateCustomerDeliveryView();
        }

        private void OnCmdNavigateToCreateHardware()
        {
            Content = new CreateHardwareView();
        }

        private void OnCmdNavigateToCreateSoftware()
        {
            Content = new CreateSoftwareView();
        }

        private void OnCmdNavigateToCreateInvoice()
        {
            Content = new CreateInvoiceView();
        }

        private void OnCmdNavigateToCreateManufacturer()
        {
            Content = new CreateManufacturerView();
        }

        private void OnCmdNavigateToCreateOrder()
        {
            Content = new CreateOrderView();
        }

        private void OnCmdNavigateToCreateService()
        {
            Content = new CreateServiceView();
        }

        private void OnCmdNavigateToCreateSupplier()
        {
            Content = new CreateSupplierView();
        }

        private void OnCmdNavigateToCreateTicket()
        {
            Content = new CreateTicketView();
        }
    }
}