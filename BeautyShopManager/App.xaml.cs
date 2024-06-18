
using BeautyShopManager.Models;
using System.Configuration;
using System.Data;
using System.Windows;

namespace BeautyShopManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ContextDataBase DB = new();
    }
    
}
