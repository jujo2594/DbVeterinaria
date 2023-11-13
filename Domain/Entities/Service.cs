using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Service
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public double Precio { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
