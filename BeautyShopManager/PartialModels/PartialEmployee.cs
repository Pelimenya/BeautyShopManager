namespace BeautyShopManager.Models;

public partial class Employee
{
    public decimal AllHours => GetAllHours();
    public string AllHoursFormatted => ConvertToHoursAndMinutes(AllHours);
    private decimal GetAllHours()
    {
        using (var context = new ContextDataBase())
        {
            return context.Workhours.Where(x => x.Employeeid == Employeeid).Sum(x => x.Hoursworked);
        }
    }
    private string ConvertToHoursAndMinutes(decimal decimalHours)
    {
        int hours = (int)decimalHours;
        int minutes = (int)((decimalHours - hours) * 60);
        return $"{hours} ч. {minutes:D2} мин.";
    }
}