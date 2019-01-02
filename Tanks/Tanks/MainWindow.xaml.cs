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

namespace Tanks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isStopped = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            App currentApp = (App)Application.Current;
            
        }

        private void BtnStartStop_Click(object sender, RoutedEventArgs e)
        {
            if (isStopped)
            {
                btnStartStop.Content = "Stop";
                isStopped = false;
                StartSimulation();
            } else
            {
                btnStartStop.Content = "Start";
                isStopped = true;
                StopSimulation();
            }
        }

        private void StartSimulation()
        {

        }

        private void StopSimulation()
        {

        }

    }
}
