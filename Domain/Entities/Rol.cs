using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Persistence.Entities;

public partial class Rol : BaseEntity
{
    public string Nombre { get; set; } = null!;

    public virtual ICollection<User> IdUsers { get; set; } = new List<User>();
}
