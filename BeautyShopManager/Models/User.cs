using System;
using System.Collections.Generic;

namespace BeautyShopManager.Models;

public partial class User
{
    public int Userid { get; set; }

    public string Username { get; set; } = null!;

    public string Passwordhash { get; set; } = null!;

    public string Role { get; set; } = null!;

    public int? Employeeid { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual ICollection<Loss> Losses { get; set; } = new List<Loss>();

    public virtual ICollection<Salesplan> Salesplans { get; set; } = new List<Salesplan>();
}
