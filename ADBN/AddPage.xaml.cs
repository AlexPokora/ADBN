using ADBN.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ADBN
{
    /// <summary>
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        public AddPage()
        {
            InitializeComponent();
            sc = new SourceClass();
            //sc.DiscTableBiding(DiscDataGrid);
           // sc.MotherBoardTableBiding(MotherBoardDataGrid);
            //sc.PowerSourceTableBiding(PowerSourseDataGrid);
            //sc.ProcessorTableBiding(ProcessorDataGrid);
            //sc.RAMTableBiding(RAMDataGrid);
            //sc.VideoCardTableBiding(VideoCardDataGrid);
            //sc.PCTableBiding(TestPC);
            //sc.SoketTableBinding(SoketDataGrid);
        }

        public SourceClass sc;

        private void button_Click(object sender, RoutedEventArgs e)
        {
            sc.SaveDiscTable(DiscDataGrid);
        }

        private void button_Copy6_Click(object sender, RoutedEventArgs e)
        {
            sc.EditDisc(DiscDataGrid.SelectedIndex);
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            sc.SaveMotherBoardTable(MotherBoardDataGrid);
        }

        private void EditMotherBoardButton(object sender, RoutedEventArgs e)
        {
            sc.EditMotherBoard(MotherBoardDataGrid.SelectedIndex);
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            sc.SavePowerSourceTable(PowerSourseDataGrid);
        }

        private void button_Copy8_Click(object sender, RoutedEventArgs e)
        {
            sc.EditPowerSource(PowerSourseDataGrid.SelectedIndex);
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            sc.SaveProcessorTable(ProcessorDataGrid);
        }

        private void button_Copy9_Click(object sender, RoutedEventArgs e)
        {
            sc.EditProcessor(ProcessorDataGrid.SelectedIndex);
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            sc.SaveRAMTable(RAMDataGrid);
        }

        private void button_Copy10_Click(object sender, RoutedEventArgs e)
        {
            sc.EditRAM(RAMDataGrid.SelectedIndex);
        }

        private void button_Copy5_Click(object sender, RoutedEventArgs e)
        {
            sc.SaveVideoCardTable(VideoCardDataGrid);
        }

        private void button_Copy12_Click(object sender, RoutedEventArgs e)
        {
            sc.EditVideoCard(VideoCardDataGrid.SelectedIndex);
        }

        private void button_Copy13_Click(object sender, RoutedEventArgs e)
        {
            sc.DeliteDisc(DiscDataGrid);
        }

        private void button_Copy14_Click(object sender, RoutedEventArgs e)
        {
           // sc.SavePCTable(TestPC);
        }

        private void button_Copy15_Click(object sender, RoutedEventArgs e)
        {
           // sc.EditPC(TestPC.SelectedIndex);
        }
    }
}

