using BeautyShopManager.Models;
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
using System.Windows.Shapes;

namespace BeautyShopManager.Windows
{
    /// <summary>
    /// Interaction logic for EditEmployeeWindow.xaml
    /// </summary>
    public partial class EditEmployeeWindow : MetroWindow
    {
        public Employee Employee { get; set; }

        public EditEmployeeWindow(Employee employee)
        {
            InitializeComponent();
            Employee = employee;
            DataContext = Employee;
            HiredatePicker.SelectedDate = Employee.Hiredate != DateTime.MinValue 
                ? Employee.Hiredate.ToLocalTime() 
                : Employee.Hiredate =  DateTime.Now;
            
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (HiredatePicker.SelectedDate.HasValue)
            {
                Employee.Hiredate = DateTime.SpecifyKind(HiredatePicker.SelectedDate.Value, DateTimeKind.Utc);
            }

            DialogResult = true;
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
