using System;
using System.Collections.Generic;

namespace volonteer.Models;

public partial class Event
{
    public int Id { get; set; }

    public string EventName { get; set; } = null!;

    public int IdCategory { get; set; }

    public DateOnly DateOfStart { get; set; }

    public string Place { get; set; } = null!;

    public int NeedVolonteer { get; set; }

    public int IdUser { get; set; }

    public int IdStatusEvent { get; set; }

    public virtual Category Category { get; set; } = null!;

    public virtual StatusEvent StatusEvent { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    public virtual ICollection<RegisterVolonteer> RegisterVolonteers { get; set; } = new List<RegisterVolonteer>();
}
