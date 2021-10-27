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
    /// Логика взаимодействия для CrateLab.xaml
    /// </summary>
    public partial class CrateLab : Window
    {
        User student;
        public CrateLab(User user)
        {
            InitializeComponent();
            CrateImg.Source = new BitmapImage(new Uri(@"\Images\CrateLab.png", UriKind.RelativeOrAbsolute));
            student = user;
        }

        private void AgreeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double succesLab = 0;
                if (FirstConnector.Text.Contains("Вход телеметрии"))
                {
                    succesLab++;
                }
                if (SecondConnector.Text.Contains("Ввод питания") )
                {
                    succesLab++;
                }
                if (ThirdConnector.Text.Contains("Ввод питания"))
                {
                    succesLab++;
                }
                if (FourthConnector.Text.Contains("Клемма заземления"))
                {
                    succesLab++;
                }

                if (succesLab != 0)
                {
                    succesLab = (succesLab / 4) * 100;
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
