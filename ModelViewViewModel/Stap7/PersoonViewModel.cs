using System;
using System.ComponentModel;
using System.Windows;

namespace ModelViewViewModel_Voorbeeld.Stap7
{
    class PersoonViewModel : INotifyPropertyChanged
    {
        public Command UpdateCommand { get; set; }
        public Command VeranderCommand { get; set; }
        public Command ToonCommand { get; set; }

        public PersoonViewModel(Persoon model)
        {
            this.Model = model;
            this.UpdateCommand = new Command(new Action(Update));
            this.VeranderCommand = new Command(new Action(Verander));
            this.ToonCommand = new Command(new Action(Toon));
        }

        private void Toon()
        {
            VulModelOp();
            MessageBox.Show(Model.ToString());
        }

        private void Verander()
        {
            Model.Naam = "Piet Snot";
            Model.Leeftijd = 99;
            Model.Geslacht = "M";
            VulViewModelOp();
        }

        private void Update()
        {
            VulModelOp();
            MessageBox.Show("Wegschrijven naar DB:" + Model.ToString());
        }

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

        private void VulModelOp()
        {
            Model.Naam = TxtNaam;
            Model.Leeftijd = int.Parse(TxtLeeftijd);
            if (IsMannelijk)
            {
                Model.Geslacht = "M";
            }
            else
            {
                Model.Geslacht = "V";
            }
        }

        private void VulViewModelOp()
        {
            TxtNaam = Model.Naam;
            TxtLeeftijd = Model.Leeftijd.ToString();
            if (Model.Geslacht.Equals("M"))
            {
                IsMannelijk = true;
            }
            else
            {
                IsMannelijk = false;
            }
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
