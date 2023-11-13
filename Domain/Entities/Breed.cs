using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Breed
{
    public int Id { get; set; }

    public string NombreRaza { get; set; } = null!;

    public virtual ICollection<Pet> Pets { get; set; } = new List<Pet>();
}
