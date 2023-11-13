using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Persistence.Entities;

public partial class City : BaseEntity
{
    public string NombreCiudad { get; set; } = null!;

    public int IdDepartamentoFk { get; set; }

    public virtual ICollection<Clientaddress> Clientaddresses { get; set; } = new List<Clientaddress>();

    public virtual State IdDepartamentoFkNavigation { get; set; } = null!;
}
