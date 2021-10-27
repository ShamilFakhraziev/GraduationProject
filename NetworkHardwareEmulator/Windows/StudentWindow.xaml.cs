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
using NetworkHardwareEmulator.Database;
using NetworkHardwareEmulator.Classes;
using NetworkHardwareEmulator.Windows;
using NetworkHardwareEmulator.Controls;

namespace NetworkHardwareEmulator.Windows
{
    /// <summary>
    /// Логика взаимодействия для StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        public StudentWindow(User user)
        {
            try
            {
                InitializeComponent();

                //заполнение прфоиля студента
                StudentFN.Text = user.FirstName;
                StudentLN.Text = user.LastName;
                if(user.ProfilePicture == null)
                {
                    StudentImg.Source = new BitmapImage(new Uri(@"\UserPicture\Student.png", UriKind.RelativeOrAbsolute));
                }
                else
                {
                    StudentImg.Source = new BitmapImage(new Uri(user.ProfilePicture, UriKind.RelativeOrAbsolute));
                }

                user.LoginDate = DateTime.Now;
                Helper.Connection.SaveChanges();

                //проверка на то пройдена ли лабораторная работа студентом
                bool isCliTelnetLabSuccess = false;
                bool isCliComportLabSuccess = false;
                bool isCentralModuleLabSuccess = false;
                bool isCrateLabSuccess = false;

                foreach (var l in Helper.Connection.LaboratoryWork.ToList())
                {
                    if(user.ID == l.UserID)
                    {
                        if (l.Name == "Подключение к CLI по протоколу Telnet")
                            isCliTelnetLabSuccess = true;
                        else if (l.Name == "Подключение к CLI через последовательный порт" )
                            isCliComportLabSuccess = true;
                        else if (l.Name == "Модуль центрального коммутатора MA4000PX")
                            isCentralModuleLabSuccess = true;
                        else if (l.Name == "Лабораторная работа Крейт")
                            isCrateLabSuccess = true;
                        
                        
                    }
                }
                //проверка на то пройден ли контрольный тест студентом
                bool isCliTelnetTestSuccess = false;
                bool isCliComportTestSuccess = false;
                bool isCentralModuleTestSuccess = false;
                bool isCrateTestSuccess = false;

                foreach (var l in Helper.Connection.ControlTest.ToList())
                {
                    if (user.ID == l.UserID)
                    {
                        if (l.Name == "Контрольные вопросы по «Подключение к CLI по протоколу Telnet»")
                            isCliTelnetTestSuccess = true;
                        else if (l.Name == "Контрольные вопросы по «Подключение к CLI через последовательный порт»")
                            isCliComportTestSuccess = true;
                        else if (l.Name == "Контрольные вопросы по «Модуль центрального коммутатора PP4X»")
                            isCentralModuleTestSuccess = true;
                        else if (l.Name == "Контрольные вопросы по «Крейт»")
                            isCrateTestSuccess = true;


                    }
                }


                    LabsList.Children.Add(new CliTelnetControl(user, isCliTelnetLabSuccess, isCliTelnetTestSuccess));
             
                    LabsList.Children.Add( new CliComPortControl(user, isCliComportLabSuccess, isCliComportTestSuccess));
             
                    LabsList.Children.Add(new CentralModuleControl(user, isCentralModuleLabSuccess, isCentralModuleTestSuccess));
            
                    LabsList.Children.Add( new CrateControl(user, isCrateLabSuccess, isCrateTestSuccess));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void BackStudentButton_Click(object sender, RoutedEventArgs e)
        {
            new AuthorizationWindow().Show();
            this.Close();
        }

        

      
    }
}
