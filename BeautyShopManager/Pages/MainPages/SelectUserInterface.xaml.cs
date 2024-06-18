using System.Windows;
using System.Windows.Controls;

namespace BeautyShopManager.Pages.MainPages
{
    public partial class SelectUserInterface : Page
    {
        public SelectUserInterface()
        {
            InitializeComponent();
        }

        private void AdministratorMenu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminMenu());
        }

        private void UserMenu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserMenu());
        }
    }
}
