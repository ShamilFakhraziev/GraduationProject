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
    /// Логика взаимодействия для CentralModule.xaml
    /// </summary>
    public partial class CentralModule : Window
    {
        User student;
        public CentralModule(User user)
        {
            try
            {

                student = user;
                InitializeComponent();
                CentralModuleImg.Source = new BitmapImage(new Uri(@"\Images\CentalModuleLabImg.png", UriKind.RelativeOrAbsolute));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AgreeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double succesLab = 0;
                if (FirstConnector.Text.Contains("Status"))
                {
                    succesLab++;
                }
                if (SecondConnector.Text.Contains("Gigabit Ethernet") && SecondConnector.Text.Contains("gigabit ethernet"))
                {
                    succesLab++;
                }
                if (ThirdConnector.Text.Contains("Link") && ThirdConnector.Text.Contains("Speed"))
                {
                    succesLab++;
                }
                if (FourthConnector.Text.Contains("USB"))
                {
                    succesLab++;
                }
                if (FifthConnector.Text == "F")
                {
                    succesLab++;
                }
                if (SixConnector.Text.Contains("Console"))
                {
                    succesLab++;
                }
                if (succesLab != 0)
                {
                    succesLab = (succesLab / 6) * 100;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
