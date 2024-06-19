using BeautyShopManager.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using BeautyShopManager.Models;
using Microsoft.EntityFrameworkCore;

namespace BeautyShopManager.Pages.AdminPages
{
    /// <summary>
    /// Interaction logic for UsersTable.xaml
    /// </summary>
    public partial class UsersTable : Page
    {
        public ObservableCollection<User> Users { get; set; }

        public UsersTable()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            using (var context = new ContextDataBase())
            {
                var users = context.Users.Include(u => u.Employee).ToList();
                Users = new ObservableCollection<User>(users);
                UsersDataGrid.ItemsSource = Users;
            }
        }

        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            var newUser = new User();
            var editWindow = new EditUserWindow(newUser);
            if (editWindow.ShowDialog() == true)
            {
                using (var context = new ContextDataBase())
                {
                    context.Users.Add(newUser);
                    context.SaveChanges();
                }
                Users.Add(newUser);
            }
        }

        private void EditUser_Click(object sender, RoutedEventArgs e)
        {
            if (UsersDataGrid.SelectedItem is User selectedUser)
            {
                var editWindow = new EditUserWindow(selectedUser);
                if (editWindow.ShowDialog() == true)
                {
                    using (var context = new ContextDataBase())
                    {
                        context.Users.Update(selectedUser);
                        context.SaveChanges();
                    }
                    UsersDataGrid.Items.Refresh();
                }
            }
        }

        private void DeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (UsersDataGrid.SelectedItem is User selectedUser)
            {
                using (var context = new ContextDataBase())
                {
                    context.Users.Remove(selectedUser);
                    context.SaveChanges();
                }
                Users.Remove(selectedUser);
            }
        }

        private void SaveUsers_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new ContextDataBase())
            {
                foreach (var user in Users)
                {
                    if (context.Entry(user).State == Microsoft.EntityFrameworkCore.EntityState.Modified)
                    {
                        context.Users.Update(user);
                    }
                    else if (context.Entry(user).State == Microsoft.EntityFrameworkCore.EntityState.Added)
                    {
                        context.Users.Add(user);
                    }
                }
                context.SaveChanges();
            }
            MessageBox.Show("Данные сохранены.");
        }

        private void RefreshUsers_Click(object sender, RoutedEventArgs e)
        {
            LoadUsers();
        }
    }
}
