using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Labb3_Theo.Models;

public partial class Personal
{
    [Key]
    public int PersonalId { get; set; }

    public string? Namn { get; set; }

    public string? Befattning { get; set; }

    public virtual Lärare? Lärare { get; set; }
}
