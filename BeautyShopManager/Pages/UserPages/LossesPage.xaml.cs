using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Controls;
using BeautyShopManager.Models;
using Microsoft.EntityFrameworkCore;

namespace BeautyShopManager.Pages.UserPages
{
    public partial class LossesPage : Page
    {
        public ObservableCollection<Loss> Losses { get; set; }

        public LossesPage()
        {
            InitializeComponent();
            Losses = new ObservableCollection<Loss>();
            LossesDataGrid.ItemsSource = Losses;
            PopulateYearComboBox();
        }

        private void PopulateYearComboBox()
        {
            int currentYear = DateTime.Now.Year;
            for (int year = currentYear - 10; year <= currentYear; year++)
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
                LoadLossesForMonth(year, month);
            }
        }

        private void LoadLossesForMonth(int year, int month)
        {
            using (var context = new ContextDataBase())
            {
                var losses = context.Losses
                                    .Where(l => l.Lossdate.Year == year && l.Lossdate.Month == month)
                                    .Include(l => l.User)
                                    .Select(l => new Loss
                                    {
                                        Lossdate = l.Lossdate,
                                        Inventoryloss = l.Inventoryloss,
                                        Shortage = l.Shortage,
                                        Disposal = l.Disposal,
                                        User = l.User,
                                    })
                                    .ToList();

                Losses.Clear();
                foreach (var loss in losses)
                {
                    Losses.Add(loss);
                }
                decimal totalLosses = losses.Sum(l => l.Inventoryloss + l.Shortage + l.Disposal);
                TotalLossesTextBlock.Text = totalLosses.ToString("F2");
            }
        }
    }
    
}
