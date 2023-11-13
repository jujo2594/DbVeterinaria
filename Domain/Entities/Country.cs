using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Persistence.Entities;

public partial class Country : BaseEntity
{
    public string NombrePais { get; set; }

    public virtual ICollection<State> States { get; set; } = new List<State>();
}
