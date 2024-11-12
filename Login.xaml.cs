using KTPMUD.Controllers;
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

namespace KTPMUD
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private readonly LoginController _loginController;
        public Login()
        {
            InitializeComponent();
            _loginController = new LoginController();
        }

        private void Button_Loaded(object sender, RoutedEventArgs e)
        {
            string username = User.Text;
            string password = Password.Password;

            if (_loginController.Login(username, password))
            {
                MainWindow mainView = new MainWindow();
                mainView.Show();
                this.Close(); // Đóng cửa sổ đăng nhập
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
