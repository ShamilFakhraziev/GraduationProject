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
    /// Логика взаимодействия для CliComPortTest.xaml
    /// </summary>
    public partial class CliComPortTest : Window
    {
        public User student;
        public CliComPortTest(User user)
        {
            InitializeComponent();
            student = user;
        }

        private void AgreeButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double succesTest = 0;
                if (FirsAnswer.Text.Contains("IPv6") || FirsAnswer.Text.Contains("ipv6"))
                {
                    succesTest++;
                }
                if (SecondAnswer.Text.Contains("Да") || SecondAnswer.Text.Contains("да"))
                {
                    succesTest++;
                }
                if (ThirdAnswer.Text.Contains("Да") || ThirdAnswer.Text.Contains("да"))
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
