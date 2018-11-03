using System;
using Prism.Mvvm;

namespace Verwaltung.ViewModels
{
    public class CreateCustomerRapportViewModel : BindableBase
    {
        private string _benutzer;
        private bool _isBenzin;
        private bool _isDiesel;
        private bool _isElektro;
        private bool _isMitfahrer;
        private bool _isPauschal;
        private bool _isRegie;
        private bool _isZug;
        private DateTime? _valutaDatum;

        public CreateCustomerRapportViewModel(string benutzer)
        {
            Benutzer = benutzer;
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

        public bool IsRegie
        {
            get => _isRegie;

            set => SetProperty(ref _isRegie, value);
        }

        public bool IsPauschal
        {
            get => _isPauschal;

            set => SetProperty(ref _isPauschal, value);
        }

        public bool IsZug
        {
            get => _isZug;

            set => SetProperty(ref _isZug, value);
        }

        public bool IsElektro
        {
            get => _isElektro;

            set => SetProperty(ref _isElektro, value);
        }

        public bool IsBenzin
        {
            get => _isBenzin;

            set => SetProperty(ref _isBenzin, value);
        }

        public bool IsDiesel
        {
            get => _isDiesel;

            set => SetProperty(ref _isDiesel, value);
        }

        public bool IsMitfahrer
        {
            get => _isMitfahrer;

            set => SetProperty(ref _isMitfahrer, value);
        }
    }
}