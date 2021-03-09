using System;

namespace ModelViewViewModel_Voorbeeld
{
    class MainWindowViewModel
    {

        public Stap10.Command Stap2Command { get; set; }
        public Stap10.Command Stap3Command { get; set; }
        public Stap10.Command Stap4Command { get; set; }
        public Stap10.Command Stap5Command { get; set; }
        public Stap10.Command Stap6Command { get; set; }
        public Stap10.Command Stap7Command { get; set; }
        public Stap10.Command Stap8Command { get; set; }
        public Stap10.Command Stap9Command { get; set; }
        public Stap10.Command Stap10Command { get; set; }

        public MainWindowViewModel()
        {

            this.Stap2Command = new Stap10.Command(new Action(Stap2));
            this.Stap3Command = new Stap10.Command(new Action(Stap3));
            this.Stap4Command = new Stap10.Command(new Action(Stap4));
            this.Stap5Command = new Stap10.Command(new Action(Stap5));
            this.Stap6Command = new Stap10.Command(new Action(Stap6));
            this.Stap7Command = new Stap10.Command(new Action(Stap7));
            this.Stap8Command = new Stap10.Command(new Action(Stap8));
            this.Stap9Command = new Stap10.Command(new Action(Stap9));
            this.Stap10Command = new Stap10.Command(new Action(Stap9));

        }


        private void Stap2()
        {
            Stap2.Persoon model = new Stap2.Persoon();
            Stap2.PersoonViewModel viewmodel = new Stap2.PersoonViewModel(model);
            Stap2.PersoonView view = new Stap2.PersoonView();
            view.DataContext = viewmodel;
            view.Show();
        }


        private void Stap3()
        {
            Stap3.Persoon model = new Stap3.Persoon();
            Stap3.PersoonViewModel viewmodel = new Stap3.PersoonViewModel(model);
            Stap3.PersoonView view = new Stap3.PersoonView();
            view.DataContext = viewmodel;
            view.Show();
        }

        private void Stap4()
        {
            Stap4.Persoon model = new Stap4.Persoon();
            Stap4.PersoonViewModel viewmodel = new Stap4.PersoonViewModel(model);
            Stap4.PersoonView view = new Stap4.PersoonView();
            view.DataContext = viewmodel;
            view.Show();
        }
        private void Stap5()
        {
            Stap5.Persoon model = new Stap5.Persoon();
            Stap5.PersoonViewModel viewmodel = new Stap5.PersoonViewModel(model);
            Stap5.PersoonView view = new Stap5.PersoonView();
            view.DataContext = viewmodel;
            view.Show();
        }

        private void Stap6()
        {
            Stap6.Persoon model = new Stap6.Persoon();
            Stap6.PersoonViewModel viewmodel = new Stap6.PersoonViewModel(model);
            Stap6.PersoonView view = new Stap6.PersoonView();
            view.DataContext = viewmodel;
            view.Show();
        }
        private void Stap7()
        {
            Stap7.Persoon model = new Stap7.Persoon();
            Stap7.PersoonViewModel viewmodel = new Stap7.PersoonViewModel(model);
            Stap7.PersoonView view = new Stap7.PersoonView();
            view.DataContext = viewmodel;
            view.Show();
        }

        private void Stap8()
        {
            Stap8.Persoon model = new Stap8.Persoon();
            Stap8.PersoonViewModel viewmodel = new Stap8.PersoonViewModel(model);
            Stap8.PersoonView view = new Stap8.PersoonView();
            view.DataContext = viewmodel;
            view.Show();
        }

        private void Stap9()
        {
            Stap9.Persoon model = new Stap9.Persoon();
            Stap9.PersoonViewModel viewmodel = new Stap9.PersoonViewModel(model);
            Stap9.PersoonView view = new Stap9.PersoonView();
            view.DataContext = viewmodel;
            view.Show();
        }

        Stap10.Persoon model = new Stap10.Persoon();
        private void Stap10()
        {

            Stap10.PersoonViewModel viewmodel = new Stap10.PersoonViewModel(model);
            Stap10.PersoonView view = new Stap10.PersoonView();
            view.DataContext = viewmodel;
            view.Show();
        }
    }
}
