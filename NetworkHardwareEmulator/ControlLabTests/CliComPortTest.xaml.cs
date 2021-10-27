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

namespace NetworkHardwareEmulator.ControlLabTests
{
    /// <summary>
    /// Логика взаимодействия для ControlTestCliTelnet.xaml
    /// </summary>
    public partial class ControlTestCliTelnet : Window
    {
        User student;
        public ControlTestCliTelnet(User user)
        {
            InitializeComponent();
            student = user;
        }

        private void AgreeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double succesTest = 0;
                if (FirsAnswer.Text.Contains("IGMP"))
                {
                    succesTest++;
                }
                if (SecondAnswer.Text.Contains("Да") || SecondAnswer.Text.Contains("да"))
                {
                    succesTest++;
                }
                if (ThirdAnswer.Text.Contains("null-modem") || ThirdAnswer.Text.Contains("null modem") || ThirdAnswer.Text.Contains("Null-modem") || ThirdAnswer.Text.Contains("Null modem"))
                {
                    succesTest++;
                }
                if (succesTest != 0)
                {
                    succesTest = (succesTest / 3) * 100;
                }
                int resultTest = Convert.ToInt32(succesTest);

                ControlTest test = new ControlTest();
                test.Name = this.Title;
                test.UserID = student.ID;
                test.SuccessRateTest = resultTest;
                test.DateTestEnding = DateTime.Now;
                Helper.Connection.ControlTest.Add(test);
                Helper.Connection.SaveChanges();
                MessageBox.Show($"Ваш результат {resultTest}%!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
    }
}
