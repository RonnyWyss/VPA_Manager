using System;
using System.Windows;
using Prism.Commands;
using Prism.Mvvm;

namespace Verwaltung.ViewModels
{
    public class CreateCustomerViewModel : BindableBase
    {
        private readonly Action _navigateBack;
        private DateTime _erfassungsdatum;
        private string _hausnummer;
        private string _kundenname;
        private string _ort;
        private string _plz;
        private string _strasse;

        public CreateCustomerViewModel(Action navigateBack)
        {
            _navigateBack = navigateBack;
            Erfassungsdatum = DateTime.Now;
            CmdSpeichern = new DelegateCommand(OnCmdSpeichern);
        }

        public string Kundenname
        {
            get => _kundenname;
            set => SetProperty(ref _kundenname, value);
        }

        public string Strasse
        {
            get => _strasse;
            set => SetProperty(ref _strasse, value);
        }

        public string Hausnummer
        {
            get => _hausnummer;
            set => SetProperty(ref _hausnummer, value);
        }

        public string Plz
        {
            get => _plz;
            set => SetProperty(ref _plz, value);
        }

        public string Ort
        {
            get => _ort;
            set => SetProperty(ref _ort, value);
        }

        public DateTime Erfassungsdatum
        {
            get => _erfassungsdatum;

            set => SetProperty(ref _erfassungsdatum, value);
        }

        public DelegateCommand CmdSpeichern { get; }

        private void OnCmdSpeichern()
        {
            if (CheckRequiredFields())
            {
                MessageBox.Show("Navigiert Zurück");
                _navigateBack();
            }
            else
            {
                MessageBox.Show("Es müssen alle Pflichtfelder ausgewählt werden");
            }
        }

        private bool CheckRequiredFields()
        {
            var kundenname = !string.IsNullOrEmpty(Kundenname);
            var strasse = !string.IsNullOrEmpty(Strasse);
            var hausnummer = !string.IsNullOrEmpty(Hausnummer);
            var plz = !string.IsNullOrEmpty(Plz);
            var ort = !string.IsNullOrEmpty(Ort);
            return kundenname && strasse && hausnummer && plz && ort;
        }
    }
}