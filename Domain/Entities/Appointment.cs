using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Persistence.Entities;

public partial class Appointment : BaseEntity
{
    public DateOnly Fecha { get; set; }

    public TimeOnly Hora { get; set; }

    public int IdClienteFk { get; set; }

    public int IdMascotaFk { get; set; }

    public int IdServicioFk { get; set; }

    public virtual Client IdClienteFkNavigation { get; set; } = null!;

    public virtual Pet IdMascotaFkNavigation { get; set; } = null!;

    public virtual Service IdServicioFkNavigation { get; set; } = null!;
}
