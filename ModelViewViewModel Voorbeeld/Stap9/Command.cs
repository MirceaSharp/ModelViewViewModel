using System;
using System.Windows.Input;

namespace ModelViewViewModel_Voorbeeld.Stap9
{
    class Command : ICommand // alles van het type command is via overerving ook van het type ICommand
    {
        private Action WhattoExecute;
        private Func<bool> WhentoExecute;

        public Command(Action What, Func<bool> When) // Point 1
        {
            WhattoExecute = What;
            WhentoExecute = When;
        }

        public Command(Action What) // Point 1
        {
            WhattoExecute = What;
        }

        public bool CanExecute(object parameter) //komt van interface
        {
            if (WhentoExecute == null)
            {
                return true;
            }
            return WhentoExecute(); // Point 2
        }

        public void Execute(object parameter)
        {
            WhattoExecute(); // Point 3
        }


        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

    }
}
