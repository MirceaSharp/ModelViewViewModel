using System.ComponentModel;

namespace ModelViewViewModel_Voorbeeld.Stap6
{
    class PersoonViewModel : INotifyPropertyChanged
    {

        private readonly Persoon Model;

        private string _txtNaam;
        private string _txtLeeftijd;
        private bool _isMannelijk;

        public string TxtNaam
        {
            get { return _txtNaam; }
            set
            {
                _txtNaam = value;
                RaisePropertyChanged("TxtNaam");
            }

        }

        public string TxtLeeftijd
        {
            get { return _txtLeeftijd; }
            set
            {
                _txtLeeftijd = value;
                RaisePropertyChanged("TxtLeeftijd");
            }

        }

        public bool IsMannelijk
        {
            get
            {
                return _isMannelijk;
            }
            set
            {
                _isMannelijk = value;
                RaisePropertyChanged("IsMannelijk");
            }
        }

        public PersoonViewModel(Persoon model)
        {
            this.Model = model;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            // take a copy to prevent thread issues
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
