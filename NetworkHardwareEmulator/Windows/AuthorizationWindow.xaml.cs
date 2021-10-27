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
using NetworkHardwareEmulator.Classes;
using NetworkHardwareEmulator.Database;
using NetworkHardwareEmulator.Windows;

namespace NetworkHardwareEmulator.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int countError = 0;
                if (LoginTB.Text == String.Empty)
                {
                    MessageBox.Show("Введите логин!");
                    return;
                }
                if (PasswordUser.Password == String.Empty)
                {
                    MessageBox.Show("Введите пароль!");
                    return;
                }
                foreach (var u in Helper.Connection.User.ToList())
                {

                    if (LoginTB.Text == u.Login && PasswordUser.Password == u.Password)
                    {
                        if (u.RoleID == 1)
                        {


                            new TeacherWindow(u).Show();
                            this.Close();
                            countError = 1;
                            return;
                        }
                        else if(u.RoleID == 2)
                        {
                            new StudentWindow(u).Show();
                         
                            this.Close();
                            countError = 1;
                            return;
                        }

                    }
                }
                if (countError == 0)
                {
                    MessageBox.Show("Данные указаны неверно");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
