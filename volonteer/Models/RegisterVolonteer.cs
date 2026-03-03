using System;
using System.Collections.Generic;

namespace volonteer.Models;

public partial class RegisterVolonteer
{
    public int Id { get; set; }

    public int IdEvent { get; set; }

    public int IdUser { get; set; }

    public DateOnly DateRegister { get; set; }

    public int IdStatusRegister { get; set; }

    public virtual Event Event { get; set; } = null!;

    public virtual StatusRegister StatusRegister { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
