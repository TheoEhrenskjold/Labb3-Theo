using System;
using System.Collections.Generic;

namespace Labb3_Theo.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string? Namn { get; set; }

    public int? Personnummer { get; set; }

    public int? KlassId { get; set; }

    public virtual ICollection<Betyg> Betygs { get; set; } = new List<Betyg>();

    public virtual Klass? Klass { get; set; }
}
