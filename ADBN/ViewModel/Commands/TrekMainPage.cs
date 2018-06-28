using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ADBN.ViewModel.Commands
{
    class TrekMainPage : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public FrameControl frc { get; set; }

        public TrekMainPage(FrameControl q)
        {
            this.frc = q;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            frc.TrekMainPage();
        }
    }
}
