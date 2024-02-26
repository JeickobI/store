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
using WpfApp1.Infastructure.Data;

namespace WpfApp1.Views
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            var login = Login.Text;
            var email = Email.Text;
            var pass = Password.Text;

            var context = new StoreDbContext();

            var user_exists = context.Users.FirstOrDefault(x => x.Login == login);
            if (user_exists is not null)
            {
                MessageBox.Show("Такой пользователь уже зарегестрирован");
                return;
            }
            var user = new Entitys.User { Login = login, Email = email, Password = pass };
            context.Users.Add(user);
            context.SaveChanges();
            MessageBox.Show("Вы зарегестрировались");
        }

        private void regist_Click(object sender, RoutedEventArgs e)
        {

        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            var win = new MainWindow();
            win.Show();
            this.Close();
        }
    }
}
