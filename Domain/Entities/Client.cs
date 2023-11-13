using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Persistence.Entities;

public partial class Client : BaseEntity
{
    public string Nombre { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual ICollection<Clientaddress> Clientaddresses { get; set; } = new List<Clientaddress>();

    public virtual ICollection<Clientphone> Clientphones { get; set; } = new List<Clientphone>();

    public virtual ICollection<Pet> Pets { get; set; } = new List<Pet>();
}
