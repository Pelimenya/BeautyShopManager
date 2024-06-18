using BeautyShopManager.Pages.MainPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace BeautyShopManager.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            string enteredLogin = login.Text;
            string enteredPassword = password.Password;

            using SHA256 sha256 = SHA256.Create();

            byte[] hashedPasswordBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(enteredPassword));

            string hashedPassword = BitConverter.ToString(hashedPasswordBytes).Replace("-", "").ToLower();

            var data = App.DB.Users.ToList();
            var user = data.FirstOrDefault(x => x.Username == enteredLogin);
            if (user != null && user.Passwordhash == hashedPassword)
            {
                _ = (user.Role.ToString() == "Administrator") ? (NavigationService.Navigate(new SelectUserInterface())) : (NavigationService.Navigate(new UserMenu()));
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            
        }
    }
}
