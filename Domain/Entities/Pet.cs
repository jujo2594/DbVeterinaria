using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Persistence.Entities;

public partial class Pet : BaseEntity
{
    public string Nombre { get; set; } = null!;

    public string Especie { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public int IdRazaFk { get; set; }

    public int IdClienteFk { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual Client IdClienteFkNavigation { get; set; } = null!;

    public virtual Breed IdRazaFkNavigation { get; set; } = null!;
}
