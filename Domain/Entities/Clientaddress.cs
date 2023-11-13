using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Clientaddress
{
    public int Id { get; set; }

    public string TipoVia { get; set; } = null!;

    public int NumeroPri { get; set; }

    public string Letra { get; set; } = null!;

    public string Bis { get; set; } = null!;

    public string LetraSec { get; set; } = null!;

    public string Cardinal { get; set; } = null!;

    public int NumeroSec { get; set; }

    public string LetraTer { get; set; } = null!;

    public int NumeroTer { get; set; }

    public string CardinalSec { get; set; } = null!;

    public string Complemento { get; set; } = null!;

    public string CodigoPostal { get; set; } = null!;

    public int IdClienteFk { get; set; }

    public int IdCiudadFk { get; set; }

    public virtual City IdCiudadFkNavigation { get; set; } = null!;

    public virtual Client IdClienteFkNavigation { get; set; } = null!;
}
