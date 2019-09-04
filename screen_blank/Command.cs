using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace screen_blank
{
    public class Command : ICommand
    {
        public void Execute(object parameter)
        {
            Environment.Exit(2);
        }

        public bool CanExecute(object parameter) => true;

        public event EventHandler CanExecuteChanged;
    }
}
