using System;
using Prism.Mvvm;

namespace Verwaltung.ViewModels
{
    public class CreateCustomerProjektViewModel : BindableBase
    {
        private string _benutzer;
        private DateTime _erfassungsdatum;
        private bool _isBenzin;
        private bool _isDiesel;
        private bool _isElektro;
        private bool _isMitfahrer;
        private bool _isPauschal;
        private bool _isRegie;
        private bool _isZug;
        private DateTime? _valutaDatum;

        public CreateCustomerProjektViewModel(string benutzername)
        {
            Benutzer = benutzername;
            Erfassungsdatum = DateTime.Now;
        }

        public string Benutzer
        {
            get => _benutzer;

            set => SetProperty(ref _benutzer, value);
        }

        public DateTime? ValutaDatum
        {
            get => _valutaDatum;

            set => SetProperty(ref _valutaDatum, value);
        }

        public DateTime Erfassungsdatum
        {
            get => _erfassungsdatum;

            set => SetProperty(ref _erfassungsdatum, value);
        }
    }
}