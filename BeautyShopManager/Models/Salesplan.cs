using System;
using System.Collections.Generic;

namespace BeautyShopManager.Models;

public partial class Salesplan
{
    public int Planid { get; set; }

    public DateOnly Planmonth { get; set; }

    public decimal Targetamount { get; set; }

    public decimal Achievedamount { get; set; }

    public int Userid { get; set; }

    public virtual User User { get; set; } = null!;
    public decimal Difference => Targetamount - Achievedamount;
}
