using KTPMUD.Controllers;
using KTPMUD.Views.Main;
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
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace KTPMUD.UserControllDT
{
    /// <summary>
    /// Interaction logic for ControlBar.xaml
    /// </summary>
    public partial class ControlBar : UserControl
    {
        public ControlBar()
        {
            InitializeComponent();
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            var currentWindow = Window.GetWindow(this);

            if (currentWindow is MainWin)
            {
                // Quay về LoginWindow khi đóng MainWindow
                var loginWindow = new Login();
                loginWindow.Show();
            }
            else
            {
                Application.Current.Shutdown();
            }

            // Đóng cửa sổ hiện tại
            currentWindow.Close();
        }
        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).WindowState = WindowState.Maximized;
        }
        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).WindowState = WindowState.Minimized;
        }
    }
    
}
