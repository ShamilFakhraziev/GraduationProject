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
    /// Логика взаимодействия для CentralModuleControl.xaml
    /// </summary>
    public partial class CentralModuleControl : UserControl
    {
        User student;
        public CentralModuleControl(User user, bool isLabSuccess, bool isTestSuccess)
        {
            InitializeComponent();
            if (isLabSuccess)
            {
                CentralModuleTheory.IsEnabled = false;
                CentralModuleWork.IsEnabled = false;
            }
            if (isTestSuccess)
            {
                CentralModuleTheory.IsEnabled = false;
                CentralModuleTest.IsEnabled = false;
            }
            if (isLabSuccess == true && isTestSuccess == true)
            {
                SuccessfulLabel.Visibility = Visibility.Visible;
            }
            CentralModuleImg.Source = new BitmapImage(new Uri(@"\Images\CentralModule.png", UriKind.RelativeOrAbsolute));
            student = user;
        }

        private void CentralModuleTheory_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               
                Process.Start(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 10) + @"\Documents\Модуль центрального коммутатора PP4X .docx");
                CentralModuleTheory.IsEnabled = false;
                if(CentralModuleTheory.IsEnabled == false && CentralModuleWork.IsEnabled == false && CentralModuleTest.IsEnabled == false)
                {
                    SuccessfulLabel.Visibility = Visibility.Visible;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CentralModuleWork_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                new CentralModule(student).ShowDialog();
                CentralModuleWork.IsEnabled = false;
                if (CentralModuleTheory.IsEnabled == false && CentralModuleWork.IsEnabled == false && CentralModuleTest.IsEnabled == false)
                {
                    SuccessfulLabel.Visibility = Visibility.Visible;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CentralModuleTest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                new CentralModuleTest(student).ShowDialog();
                CentralModuleTest.IsEnabled = false;
                if (CentralModuleTheory.IsEnabled == false && CentralModuleWork.IsEnabled == false && CentralModuleTest.IsEnabled == false)
                {
                    SuccessfulLabel.Visibility = Visibility.Visible;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
