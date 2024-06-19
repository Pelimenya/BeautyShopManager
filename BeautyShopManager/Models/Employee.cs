using System;
using System.Collections.Generic;

namespace BeautyShopManager.Models;

public partial class Employee
{
    public int Employeeid { get; set; }

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Position { get; set; } = null!;

    public DateTime Hiredate { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();

    public virtual ICollection<Workhour> Workhours { get; set; } = new List<Workhour>();
}
