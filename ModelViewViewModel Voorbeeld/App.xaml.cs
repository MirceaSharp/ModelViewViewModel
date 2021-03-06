using System.Windows;

namespace ModelViewViewModel_Voorbeeld
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        //private void Application_Startup(object sender, StartupEventArgs e)
        //{
        //    Stap2.Persoon model = new Stap2.Persoon();
        //    Stap2.PersoonViewModel viewmodel = new Stap2.PersoonViewModel(model);
        //    Stap2.PersoonView view = new Stap2.PersoonView();
        //    view.DataContext = viewmodel;
        //    view.Show();
        //}

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindowViewModel viewmodel = new MainWindowViewModel();
            MainWindow view = new MainWindow();
            view.DataContext = viewmodel;
            view.Show();
        }

    }
}
