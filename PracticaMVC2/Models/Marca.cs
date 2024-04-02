using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PracticaMVC2.Models;

public partial class Marca
{
    [Key]
    [Display(Name = "ID")]
    public int IdMarcas { get; set; }

    [Display(Name = "Nombre de la Marca")]
    public string? NombreMarca { get; set; }

    [Display(Name = "Estado")]
    public string? Estados { get; set; }

    public virtual ICollection<Equipo> Equipos { get; set; } = new List<Equipo>();
}
