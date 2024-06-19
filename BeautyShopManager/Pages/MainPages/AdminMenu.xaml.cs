using MahApps.Metro.Controls;
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

namespace BeautyShopManager.Pages.MainPages
{
    /// <summary>
    /// Interaction logic for AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Page
    {
        public AdminMenu()
        {
            InitializeComponent();
            
        }

        private void HamburgerMenuControl_OnItemClick(object sender, MahApps.Metro.Controls.ItemClickEventArgs args)
        {
            var menuItem = (HamburgerMenuGlyphItem)args.ClickedItem;
            if (menuItem != null && menuItem.Label == "Выйти из аккаунта") 
            {
                NavigationService.Navigate(new LoginPage());
            }
            TableMenu.SetCurrentValue(ContentProperty, args.ClickedItem);
            TableMenu.SetCurrentValue(HamburgerMenu.IsPaneOpenProperty, false);
        }
    }
}
