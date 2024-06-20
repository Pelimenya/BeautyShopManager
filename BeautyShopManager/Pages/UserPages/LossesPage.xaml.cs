using System.Collections.ObjectModel;
using System.Windows.Controls;
using BeautyShopManager.Models;
using Microsoft.EntityFrameworkCore;

namespace BeautyShopManager.Pages.UserPages;

public partial class LossesPage : Page
{
    public ObservableCollection<Loss> Losses { get; set; }

    public LossesPage()
    {
        InitializeComponent();
        Losses = new ObservableCollection<Loss>();
        LossesDataGrid.ItemsSource = Losses;
    }

    private void MonthPicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
    {
        if (MonthPicker.SelectedDate.HasValue)
        {
            DateTime selectedDate = MonthPicker.SelectedDate.Value;
            LoadLossesForMonth(selectedDate);
        }
    }

    private void LoadLossesForMonth(DateTime selectedDate)
    {
        int year = selectedDate.Year;
        int month = selectedDate.Month;

        using (var context = new ContextDataBase())
        {
            var losses = context.Losses.Where(l => l.Lossdate.Year == year && l.Lossdate.Month == month)
                .Include(l => l.User)
                .Select(l => new Loss
                {
                    Lossdate = l.Lossdate,
                    Inventoryloss = l.Inventoryloss,
                    Shortage = l.Shortage,
                    Disposal = l.Disposal,
                    User = l.User
                })
                .ToList();

            Losses.Clear();
            foreach (var loss in losses)
            {
                Losses.Add(loss);
            }
        }
    }
}