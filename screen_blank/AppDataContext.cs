using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace screen_blank
{
    class AppDataContext
    {

        ICommand _Command = new Command();

        public ICommand Command
        {
            get { return _Command; }
        }


    }
}
