using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class City
{
    public int Id { get; set; }

    public string NombreCiudad { get; set; } = null!;

    public int IdDepartamentoFk { get; set; }

    public virtual ICollection<Clientaddress> Clientaddresses { get; set; } = new List<Clientaddress>();

    public virtual State IdDepartamentoFkNavigation { get; set; } = null!;
}
