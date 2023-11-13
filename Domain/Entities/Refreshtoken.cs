using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Persistence.Entities;

public partial class Refreshtoken : BaseEntity
{
    public string Token { get; set; } = null!;

    public bool IsExpired => DateTime.UtcNow >= Expires;

    public DateTime Expires { get; set; }

    public DateTime Created { get; set; }

    public DateTime? Revoked { get; set; }

    public bool IsActive => Revoked == null && !IsExpired;
    
    public int IdUserfK { get; set; }

    public virtual User IdUserfKNavigation { get; set; } = null!;
}
