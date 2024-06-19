using BeautyShopManager.Models;
using BeautyShopManager.Windows;
using Microsoft.EntityFrameworkCore;
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

namespace BeautyShopManager.Pages.UserPages
{
    /// <summary>
    /// Interaction logic for EmployeesTable.xaml
    /// </summary>
    public partial class EmployeesTable : Page
    {
        public ObservableCollection<Employee> Employees { get; set; }

        public EmployeesTable()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            using (var context = new ContextDataBase())
            {
                var employees = context.Employees.Include(e => e.Users).Include(e => e.Workhours).ToList();
                Employees = new ObservableCollection<Employee>(employees);
                EmployeesDataGrid.ItemsSource = Employees;
            }
        }

        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var newEmployee = new Employee();
                var editWindow = new EditEmployeeWindow(newEmployee);
                if (editWindow.ShowDialog() == true)
                {
                    using (var context = new ContextDataBase())
                    {
                        context.Employees.Add(newEmployee);
                        context.SaveChanges();
                    }
                    Employees.Add(newEmployee);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ошибка!" + ex.Message);
            }
        }

        private void EditEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeesDataGrid.SelectedItem is Employee selectedEmployee)
            {
                var editWindow = new EditEmployeeWindow(selectedEmployee);
                if (editWindow.ShowDialog() == true)
                {
                    using (var context = new ContextDataBase())
                    {
                        context.Employees.Update(selectedEmployee);
                        context.SaveChanges();
                    }
                    EmployeesDataGrid.Items.Refresh();
                }
            }
        }

        private void DeleteEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeesDataGrid.SelectedItem is Employee selectedEmployee)
            {
                using (var context = new ContextDataBase())
                {
                    context.Employees.Remove(selectedEmployee);
                    context.SaveChanges();
                }
                Employees.Remove(selectedEmployee);
            }
        }
        // Кнопка утратила свою потребность во время разработки.
        private void SaveEmployees_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new ContextDataBase())
            {
                foreach (var employee in Employees)
                {
                    if (context.Entry(employee).State == Microsoft.EntityFrameworkCore.EntityState.Modified)
                    {
                        context.Employees.Update(employee);
                    }
                    else if (context.Entry(employee).State == Microsoft.EntityFrameworkCore.EntityState.Added)
                    {
                        context.Employees.Add(employee);
                    }
                }
                context.SaveChanges();
            }
            MessageBox.Show("Данные сохранены.");
        }

        private void RefreshEmployees_Click(object sender, RoutedEventArgs e)
        {
            LoadEmployees();
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = SearchTextBox.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                EmployeesDataGrid.ItemsSource = Employees;
                return;
            }

            var filteredEmployees = Employees.Where(e => e.Firstname.ToLower().Contains(searchText) ||
                                                         e.Lastname.ToLower().Contains(searchText) ||
                                                         e.Position.ToLower().Contains(searchText));

            EmployeesDataGrid.ItemsSource = filteredEmployees;
        }
    }
}
