using NetworkHardwareEmulator.ControlLabTests;
using NetworkHardwareEmulator.Database;
using NetworkHardwareEmulator.Windows;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace NetworkHardwareEmulator.Controls
{
    /// <summary>
    /// Логика взаимодействия для CliTelnetControl.xaml
    /// </summary>
    public partial class CliTelnetControl : UserControl
    {
        private User student;
        public CliTelnetControl(User user, bool isLabSuccess, bool isTestSuccess)
        {
            InitializeComponent();
            if (isLabSuccess)
            {
               
                CliTelnetTheory.IsEnabled = false;
                CliTelnetWork.IsEnabled = false;
               
            }
            if (isTestSuccess)
            {
            
                CliTelnetTheory.IsEnabled = false;
                CliTelnetTest.IsEnabled = false;
            }
            if (isLabSuccess == true && isTestSuccess == true)
            {
                SuccessfulLabel.Visibility = Visibility.Visible;
            }
            student = user;
            CliTelnetImg.Source = new BitmapImage(new Uri(@"\Images\CliTelnet.png", UriKind.RelativeOrAbsolute));
        }

        private void CliTelnetTheory_Click(object sender, RoutedEventArgs e)
        {
           
            try
            {
                Process.Start(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length-10) + @"\Documents\Подключение к CLI по протоколу Telnet .docx");
                CliTelnetTheory.IsEnabled = false;
                if (CliTelnetTheory.IsEnabled == false && CliTelnetWork.IsEnabled == false && CliTelnetTest.IsEnabled == false)
                {
                    SuccessfulLabel.Visibility = Visibility.Visible;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CliTelnetWork_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                new CliTelnetLab(student).ShowDialog();
                CliTelnetWork.IsEnabled = false;
                if (CliTelnetTheory.IsEnabled == false && CliTelnetWork.IsEnabled == false && CliTelnetTest.IsEnabled == false)
                {
                    SuccessfulLabel.Visibility = Visibility.Visible;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CliTelnetTest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                new CliComPortTest(student).ShowDialog();
                CliTelnetTest.IsEnabled = false;
                if (CliTelnetTheory.IsEnabled == false && CliTelnetWork.IsEnabled == false && CliTelnetTest.IsEnabled == false)
                {
                    SuccessfulLabel.Visibility = Visibility.Visible;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
