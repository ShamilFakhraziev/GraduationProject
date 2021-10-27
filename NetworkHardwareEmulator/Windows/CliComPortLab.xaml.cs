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
    /// Логика взаимодействия для CliComPortLab.xaml
    /// </summary>
    public partial class CliComPortLab : Window
    {
        User student;
        public CliComPortLab(User user)
        {
            InitializeComponent();
            student = user;
        }

        private void AgreeAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double succesLab = 0;
                if (SpeedAnswer.Text.Contains("115200"))
                {
                    succesLab++;
                }
                if (DataBitAnswer.Text == "8")
                {
                    succesLab++;
                }
                if (EvensAnswer.Text.Contains("нет") && EvensAnswer.Text.Contains("Нет"))
                {
                    succesLab++;
                }
                if (StopBitAnswer.Text == "1")
                {
                    succesLab++;
                }
                if (StreamControlAnswer.Text.Contains("отсутствует"))
                {
                    succesLab++;
                }
                if (LoginInputTB.Text == "admin")
                {
                    succesLab++;
                }
                if (PasswordInputTB.Text == "password")
                {
                    succesLab++;
                }
                if (succesLab != 0)
                {
                    succesLab = (succesLab / 7) * 100;
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
