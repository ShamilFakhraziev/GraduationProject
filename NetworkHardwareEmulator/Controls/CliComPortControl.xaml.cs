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
    /// Логика взаимодействия для CliComPortControl.xaml
    /// </summary>
    public partial class CliComPortControl : UserControl
    {
        User student;
        public CliComPortControl(User user, bool isLabSuccess, bool isTestSuccess)
        {
            InitializeComponent();
            if (isLabSuccess)
            {
                
                CliComPortTheory.IsEnabled = false;
                CliComPortWork.IsEnabled = false;
            }
            if (isTestSuccess)
            {
                
                CliComPortTheory.IsEnabled = false;
                CliComPortTest.IsEnabled = false;
            }
            if (isLabSuccess == true && isTestSuccess == true)
            {
                SuccessfulLabel.Visibility = Visibility.Visible;
            }
            student = user;
            CliComPortImg.Source = new BitmapImage(new Uri(@"\Images\CliCom.jpg", UriKind.RelativeOrAbsolute));

        }

        private void CliComPortTheory_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Process.Start(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 10) + @"\Documents\Подключение к CLI через последовательный порт .docx");
                CliComPortTheory.IsEnabled = false;
                if(CliComPortTheory.IsEnabled == false && CliComPortTest.IsEnabled == false && CliComPortWork.IsEnabled == false)
                {
                    SuccessfulLabel.Visibility = Visibility.Visible;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CliComPortWork_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                new CliComPortLab(student).ShowDialog();
                CliComPortWork.IsEnabled = false;
                if (CliComPortTheory.IsEnabled == false && CliComPortTest.IsEnabled == false && CliComPortWork.IsEnabled == false)
                {
                    SuccessfulLabel.Visibility = Visibility.Visible;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CliComPortTest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                new ControlTestCliTelnet(student).ShowDialog();
                CliComPortTest.IsEnabled = false;
                if (CliComPortTheory.IsEnabled == false && CliComPortTest.IsEnabled == false && CliComPortWork.IsEnabled == false)
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
