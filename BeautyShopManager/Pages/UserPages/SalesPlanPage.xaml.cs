using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Controls;
using BeautyShopManager.Models;
using Microsoft.EntityFrameworkCore;

namespace BeautyShopManager.Pages.UserPages
{
    public partial class SalesPlanPage : Page
    {
        public ObservableCollection<Salesplan> SalesPlans { get; set; }

        public SalesPlanPage()
        {
            InitializeComponent();
            SalesPlans = new ObservableCollection<Salesplan>();
            SalesPlanDataGrid.ItemsSource = SalesPlans;
            PopulateYearComboBox();
        }

        private void PopulateYearComboBox()
        {
            int currentYear = DateTime.Now.Year;
            for (int year = currentYear - 10; year <= currentYear + 10; year++)
            {
                YearComboBox.Items.Add(new ComboBoxItem { Content = year.ToString(), Tag = year });
            }
        }

        private void DateSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MonthComboBox.SelectedItem != null && YearComboBox.SelectedItem != null)
            {
                int month = int.Parse(((ComboBoxItem)MonthComboBox.SelectedItem).Tag.ToString());
                int year = int.Parse(((ComboBoxItem)YearComboBox.SelectedItem).Tag.ToString());
                LoadSalesPlanForMonth(year, month);
            }
        }

        private void LoadSalesPlanForMonth(int year, int month)
        {
            using (var context = new ContextDataBase())
            {
                var salesPlans = context.Salesplans
                    .Where(sp => sp.Planmonth.Year == year && sp.Planmonth.Month == month)
                    .Include(sp => sp.User)
                    .ToList();

                SalesPlans.Clear();
                foreach (var salesPlan in salesPlans)
                {
                    SalesPlans.Add(salesPlan);
                }
            }
        }
    }
}