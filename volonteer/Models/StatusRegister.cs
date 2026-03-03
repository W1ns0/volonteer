using System;
using System.Collections.Generic;

namespace volonteer.Models;

public partial class StatusRegister
{
    public int Id { get; set; }

    public string StatusName { get; set; } = null!;

    public virtual ICollection<RegisterVolonteer> RegisterVolonteers { get; set; } = new List<RegisterVolonteer>();
}
