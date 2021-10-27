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

namespace NetworkHardwareEmulator.Windows
{
    /// <summary>
    /// Логика взаимодействия для TeacherWindow.xaml
    /// </summary>
    public partial class TeacherWindow : Window
    {
        public List<User> studentsList = new List<User>();
        public List<User> succesStudentsList = new List<User>();
        public TeacherWindow(User user)
        {
            try
            {
                InitializeComponent();
                TeacherFN.Text = user.FirstName;
                TeacherLN.Text = user.LastName;
                if (user.ProfilePicture == null)
                {
                    TeacherImg.Source = new BitmapImage(new Uri(@"\UserPicture\Teacher.jpg", UriKind.RelativeOrAbsolute));
                }
                else
                {
                    TeacherImg.Source = new BitmapImage(new Uri(user.ProfilePicture, UriKind.RelativeOrAbsolute));
                }

                user.LoginDate = DateTime.Now;
                Helper.Connection.SaveChanges();
              
                foreach (var u in Helper.Connection.User.ToList())
                {
                    if(u.RoleID == 2)
                    {
                        studentsList.Add(u);
                        Students.Items.Add(u);
                    }
                }
                foreach(var l in Helper.Connection.LaboratoryWork.ToList())
                {
                    StudentsLabSuccess.Items.Add(l);
                }
                foreach (var t in Helper.Connection.ControlTest.ToList())
                {
                    StudentsTestSuccess.Items.Add(t);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Sort()
        {
            try
            {
                studentsList.Clear();
                foreach (var students in Helper.Connection.User.ToList())
                {
                    if (students.RoleID == 2)
                    {
                        studentsList.Add(students);

                    }
                }
                foreach (var students in studentsList)
                {
                    studentsList = studentsList.Where(p => p.FirstName.Contains(SearchTB.Text) || p.LastName.Contains(SearchTB.Text)).ToList();
                }
                Students.Items.Clear();
                foreach (var students in studentsList)
                {


                    Students.Items.Add(students);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            Sort();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            new AuthorizationWindow().Show();
            this.Close();
        }

        
    }
}
