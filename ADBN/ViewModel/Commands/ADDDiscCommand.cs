using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ADBN.ViewModel.Commands
{
    class ADDDiscCommand : ICommand
    {
            public event EventHandler CanExecuteChanged;

            public ADDViewModel avm { get; set; }

            public ADDDiscCommand(ADDViewModel avm)
            {
                this.avm = avm;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
            this.avm.ADDisc();
            }


        }
    }
