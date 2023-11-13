using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Clientphone
{
    public int Id { get; set; }

    public string Numero { get; set; } = null!;

    public int IdClienteFk { get; set; }

    public virtual Client IdClienteFkNavigation { get; set; } = null!;
}
