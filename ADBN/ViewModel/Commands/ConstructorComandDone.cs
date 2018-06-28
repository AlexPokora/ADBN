using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ADBN.ViewModel.Commands
{
    class ConstructorComandDone : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public ConstructorViewModel cwm { get; set; }
        
        public ConstructorComandDone(ConstructorViewModel q)
        {
            this.cwm = q;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }



    }
}
