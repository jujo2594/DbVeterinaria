using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Persistence.Entities;

public partial class Clientphone : BaseEntity
{
    public string Numero { get; set; } = null!;

    public int IdClienteFk { get; set; }

    public virtual Client IdClienteFkNavigation { get; set; } = null!;
}
