using System;
using System.Collections.Generic;

namespace volonteer.Models;

public partial class StatusEvent
{
    public int Id { get; set; }

    public string StatusName { get; set; } = null!;

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
