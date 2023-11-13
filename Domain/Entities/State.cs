using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class State
{
    public int Id { get; set; }

    public string NombreDepartamento { get; set; }

    public int IdPaisFk { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual Country IdPaisFkNavigation { get; set; } = null!;
}
