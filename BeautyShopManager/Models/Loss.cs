using System;
using System.Collections.Generic;

namespace BeautyShopManager.Models;

public partial class Loss
{
    public int Lossid { get; set; }

    public DateOnly Lossdate { get; set; }

    public decimal Inventoryloss { get; set; }

    public decimal Shortage { get; set; }

    public decimal Disposal { get; set; }

    public int Userid { get; set; }

    public virtual User User { get; set; } = null!;
}
