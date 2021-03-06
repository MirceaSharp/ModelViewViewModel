using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace ModelViewViewModel_Voorbeeld.Stap8
{
    class PersoonViewModel : INotifyPropertyChanged, IDataErrorInfo
    {

        private readonly Persoon Model;

        private string _txtNaam;
        private string _txtLeeftijd;
        private bool _isMannelijk;

        public Command UpdateCommand { get; set; }
        public Command VeranderCommand { get; set; }
        public Command ToonCommand { get; set; }


        public PersoonViewModel(Persoon model)
        {
            this.Model = model;
            this.UpdateCommand = new Command(new Action(Update));
            this.VeranderCommand = new Command(new Action(Verander));
            this.ToonCommand = new Command(new Action(Toon), () => IsValid());
        }

        private void Toon()
        {
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
            if (IsValid())
            {
                VulModelOp();
                MessageBox.Show("Wegschrijven naar DB:" + Model.ToString());
            }
            else
            {
                MessageBox.Show(Error);
            }
        }


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
                if (Model.Geslacht.Equals("M"))
                {
                    _isMannelijk = true;
                }
                else
                {
                    _isMannelijk = false;
                }

                return _isMannelijk;
            }
            set
            {
                _isMannelijk = value;

                RaisePropertyChanged("IsMannelijk");

            }
        }
        private void VulViewModelOp()
        {
            TxtNaam = Model.Naam;
            TxtLeeftijd = Model.Leeftijd.ToString();
            if (Model.Geslacht.Equals("M"))
                IsMannelijk = true;
            else
                IsMannelijk = false;

        }

        public void VulModelOp()
        {
            if (IsValid())
            {
                Model.Naam = TxtNaam;
                Model.Leeftijd = int.Parse(TxtLeeftijd);
                if (_isMannelijk)
                    Model.Geslacht = "M";
                else
                    Model.Geslacht = "V";
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



        private Dictionary<string, string> _errors = new Dictionary<string, string>();

        public string Error
        {
            get
            {
                string result = "";
                foreach (string item in _errors.Values)
                {
                    result += item + Environment.NewLine;
                }
                return result;
            }
        }

        private bool IsValid()
        {
            if (_errors.Values.Count <= 0)
            {
                return true;
            }
            return false;
        }

        public string this[string columnName]
        {
            get
            {
                string result = null;
                int lft = 0;
                if (columnName == "TxtNaam")
                {
                    if (string.IsNullOrEmpty(TxtNaam))
                    {
                        result = "Geef een naampje in";
                    }
                }
                if (columnName == "TxtLeeftijd")
                {
                    if (string.IsNullOrEmpty(TxtLeeftijd))
                    {
                        result = "Geef een leeftijd in";
                    }
                    else
                    {
                        if (!int.TryParse(TxtLeeftijd, out lft))
                        {
                            result = "Geef een numerieke waarde in bij leeftijd!";
                        }

                    }
                }
                if (string.IsNullOrEmpty(result))
                {
                    _errors.Remove(columnName);
                }
                else
                {
                    _errors.Remove(columnName);
                    _errors.Add(columnName, result);
                }
                return result;
            }
        }
    }
}
