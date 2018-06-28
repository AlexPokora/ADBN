using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ADBN.ViewModel.Commands;
using System.ComponentModel;

namespace ADBN
{
    class FrameControl : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, e);
        }
        protected void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        public TrekMainPage cTrekMainPage { get; set; }
        public TrekAddPage cTrekAddPage { get; set; }
        public TrekConstructorPage cTrekConstructorPage { get; set; }
        public Frame mainFrame { get; set; } = new Frame();

        public FrameControl()
        {
            mainFrame.NavigationService.Navigate(new Uri("MainPage.xaml", UriKind.Relative));
            this.cTrekMainPage = new TrekMainPage(this);
            this.cTrekAddPage = new TrekAddPage(this);
            this.cTrekConstructorPage = new TrekConstructorPage(this);
        }

        public void TrekMainPage()
        {
            mainFrame.NavigationService.Navigate(new Uri("MainPage.xaml", UriKind.Relative));
            OnPropertyChanged("mainFrame");
        }

        public void TrekAddPage()
        {
            mainFrame.NavigationService.Navigate(new Uri("AddPage.xaml", UriKind.Relative));
            OnPropertyChanged("mainFrame");
        }

        public void TrekConstructorPage()
        {
            mainFrame.NavigationService.Navigate(new Uri("ConstructorPage.xaml", UriKind.Relative));
            OnPropertyChanged("mainFrame");
        }

    }
}
