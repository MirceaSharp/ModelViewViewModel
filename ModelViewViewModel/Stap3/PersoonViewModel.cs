using System.ComponentModel;

namespace ModelViewViewModel_Voorbeeld.Stap3
{
    class PersoonViewModel : INotifyPropertyChanged
    {

        private readonly Persoon model;

        public PersoonViewModel(Persoon model)
        {
            this.model = model;
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
