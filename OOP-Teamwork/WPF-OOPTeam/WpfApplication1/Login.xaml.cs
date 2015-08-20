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
using EventScheduler.Data;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        //MainWindow win = new MainWindow();

        public Login()
        {
            InitializeComponent();
            MyLoginWindow.Top = (SystemParameters.PrimaryScreenHeight / 2) - MyLoginWindow.Height;
            MyLoginWindow.Left = (SystemParameters.PrimaryScreenWidth / 2) - MyLoginWindow.Width;
            //win.Show();
            txtBoxForPassWord.Visibility = System.Windows.Visibility.Hidden;
            
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            foreach (Window item in Application.Current.Windows)
            {
                if (item.GetType() == typeof(MainWindow))
                {
                    (item as MainWindow).ButtonLogin.IsEnabled = true;
                }
            }
            
            base.OnClosing(e);
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (Admin.IsCorrect(PassBox.Password))
            {
                foreach (Window item in Application.Current.Windows)
                {
                    if (item.GetType() == typeof(MainWindow))
                    {
                        (item as MainWindow).AddEvent.IsEnabled = true;
                        (item as MainWindow).ButtonLogin.IsEnabled = true;
                    }
                }
                MyLoginWindow.Close();
            }
            else
            {
                PassBox.Background = Brushes.Red;
            }
            
        }
        public void ShowPassword()
        {
            PassBox.Visibility = System.Windows.Visibility.Hidden;
            txtBoxForPassWord.Visibility = System.Windows.Visibility.Visible;
            txtBoxForPassWord.Text = PassBox.Password;
        }
        public void HidePassword()
        {
            PassBox.Visibility = System.Windows.Visibility.Visible;
            txtBoxForPassWord.Visibility = System.Windows.Visibility.Hidden;
            txtBoxForPassWord.Text = PassBox.Password;
            PassBox.Focus();
        }
        

        private void ShowPass_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            ShowPassword();
        }

        private void ShowPass_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            HidePassword();
        }
    }
}
