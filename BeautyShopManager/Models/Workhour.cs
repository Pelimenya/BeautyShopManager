using System;
using System.Collections.Generic;

namespace BeautyShopManager.Models;

public partial class Workhour
{
    public int Workhourid { get; set; }

    public int Employeeid { get; set; }

    public DateOnly Workdate { get; set; }

    public decimal Hoursworked { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
