using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PracticaMVC2.Models;

public partial class EstadosEquipo
{
    [Key]

    [Display(Name = "ID")]
    public int IdEstadosEquipo { get; set; }

    [Display(Name = "Descripcion equipo")]
    public string? Descripcion { get; set; }

    [Display(Name = "Estado")]
    public string? Estado { get; set; }

    public virtual ICollection<Equipo> Equipos { get; set; } = new List<Equipo>();
}
