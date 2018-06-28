using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ADBN.Model;

namespace ADBN.ViewModel.Commands
{
    class LoadInDataBaseCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public AddWindowModel awm { get; set; }

        public LoadInDataBaseCommand(AddWindowModel q)
        {
            this.awm = q;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            awm.AddDisc();
        }

    }
}
