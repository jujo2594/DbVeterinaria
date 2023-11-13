using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Persistence.Entities;

public partial class Breed : BaseEntity
{
    public string NombreRaza { get; set; } = null!;

    public virtual ICollection<Pet> Pets { get; set; } = new List<Pet>();
}
