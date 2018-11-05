using System;
using System.Windows;
using System.Windows.Controls;
using Prism.Commands;
using Prism.Mvvm;
using Verwaltung.Services;

namespace Verwaltung.ViewModels
{
    public class CreateCompanyViewModel : BindableBase
    {
        private readonly Action _navigateBack;
        private string _benutzer;
        private DateTime _erfassungsdatum;
        private string _hausnummer;
        private string _kundenname;
        private DataGrid _mitarbeiter;
        private string _ort;
        private string _plz;
        private string _strasse;
        private Company _company;

        public CreateCompanyViewModel(string benutzername)
        {
            Benutzer = benutzername;
            Erfassungsdatum = DateTime.Now;
            CmdSpeichern = new DelegateCommand(OnCmdSpeichern);
            Company = new Company();
            Company.GetDemoData();
        }

        public Company Company
        {
            get => _company;

            set => SetProperty(ref _company, value);
        }

        public string Benutzer
        {
            get => _benutzer;

            set => SetProperty(ref _benutzer, value);
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