using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Persistence.Entities;

public partial class State : BaseEntity
{
    public string NombreDepartamento { get; set; }

    public int IdPaisFk { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual Country IdPaisFkNavigation { get; set; } = null!;
}
