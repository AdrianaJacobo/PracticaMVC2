using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PracticaMVC2.Models;

public partial class TipoEquipo
{
    [Key]

    [Display(Name = "ID")]
    public int IdTipoEquipo { get; set; }

    [Display(Name = "Descripcion Equipo")]
    public string? Descripcion { get; set; }

    [Display(Name = "Estado")]
    public string? Estado { get; set; }

    public virtual ICollection<Equipo> Equipos { get; set; } = new List<Equipo>();
}
