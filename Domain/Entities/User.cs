using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Persistence.Entities;

public partial class User : BaseEntity
{
    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<Refreshtoken> Refreshtokens { get; set; } = new List<Refreshtoken>();

    public virtual ICollection<Rol> IdRols { get; set; } = new List<Rol>();
}
