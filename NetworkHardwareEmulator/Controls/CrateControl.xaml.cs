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
    /// Логика взаимодействия для CrateControl.xaml
    /// </summary>
    public partial class CrateControl : UserControl
    {
        User student;
        public CrateControl(User user, bool isLabSuccess, bool isTestSuccess)
        {
            InitializeComponent();
            if (isLabSuccess)
            {
               
                CrateTheory.IsEnabled = false;
                CrateWork.IsEnabled = false;
           
            }
            if (isTestSuccess)
            {
              
                CrateTheory.IsEnabled = false;
                CrateTest.IsEnabled = false;
            }
            if (isLabSuccess == true && isTestSuccess == true)
            {
                SuccessfulLabel.Visibility = Visibility.Visible;
            }
            CrateImg.Source = new BitmapImage(new Uri(@"\Images\Crate.png", UriKind.RelativeOrAbsolute));
            student = user;
        }

        private void CrateTheory_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                Process.Start(Environment.CurrentDirectory.Remove(Environment.CurrentDirectory.Length - 10) + @"\Documents\Крейт.docx");
                CrateTheory.IsEnabled = false;
                if(CrateTheory.IsEnabled == false && CrateWork.IsEnabled == false && CrateTest.IsEnabled == false)
                {
                    SuccessfulLabel.Visibility = Visibility.Visible;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CrateWork_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                new CrateLab(student).ShowDialog();
                CrateWork.IsEnabled = false;
                if (CrateTheory.IsEnabled == false && CrateWork.IsEnabled == false && CrateTest.IsEnabled == false)
                {
                    SuccessfulLabel.Visibility = Visibility.Visible;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CrateTest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                new CrateTest(student).ShowDialog();
                CrateTest.IsEnabled = false;
                if (CrateTheory.IsEnabled == false && CrateWork.IsEnabled == false && CrateTest.IsEnabled == false)
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
