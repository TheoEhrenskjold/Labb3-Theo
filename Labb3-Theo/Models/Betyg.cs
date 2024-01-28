using System;
using System.Collections.Generic;

namespace Labb3_Theo.Models;

public partial class Betyg
{
    public int BetygsId { get; set; }

    public int? StudentId { get; set; }

    public int? KursId { get; set; }

    public int? LärarId { get; set; }

    public string? Betyg1 { get; set; }

    public DateOnly? Datum { get; set; }

    public virtual Kur? Kurs { get; set; }

    public virtual Lärare? Lärar { get; set; }

    public virtual Student? Student { get; set; }
}
