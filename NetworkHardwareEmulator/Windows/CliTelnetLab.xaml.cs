using NetworkHardwareEmulator.Classes;
using NetworkHardwareEmulator.Database;
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
using System.Windows.Shapes;

namespace NetworkHardwareEmulator.Windows
{
    /// <summary>
    /// Логика взаимодействия для CliTelnetLab.xaml
    /// </summary>
    public partial class CliTelnetLab : Window
    {
        public User student;
        public CliTelnetLab(User user)
        {
            try
            {
               

                InitializeComponent();
                student = user;
                TcpIpConfig.Source = new BitmapImage(new Uri(@"\Images\CliTelnetLabTcp.jpg", UriKind.RelativeOrAbsolute));

                PuskPanel.Source = new BitmapImage(new Uri(@"\Images\CliTelnetLabPusk.jpg", UriKind.RelativeOrAbsolute));
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AgreeAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double succesLab = 0;
                if (IpAdreesInput.Text.Contains("192.168.1.1"))
                {
                    succesLab++;
                }
                if (MaskInput.Text.Contains("255.255.255.0"))
                {
                    succesLab++;
                }
                if (PuskPanelInput.Text.Contains("192.168.1.2") && PuskPanelInput.Text.Contains("telnet"))
                {
                    succesLab++;
                }
                if (succesLab != 0)
                {
                    succesLab = (succesLab / 3) * 100;
                }
                int resultLab = Convert.ToInt32(succesLab);
               

                    LaboratoryWork lab = new LaboratoryWork();

                    lab.Name = this.Title;
                    lab.UserID = student.ID;
                    lab.SuccessRateLab = resultLab;
                    lab.DateWorkEnding = DateTime.Now;
                    Helper.Connection.LaboratoryWork.Add(lab);
                
                Helper.Connection.SaveChanges();
                MessageBox.Show($"Ваш результат {resultLab}%!");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
    }
}
