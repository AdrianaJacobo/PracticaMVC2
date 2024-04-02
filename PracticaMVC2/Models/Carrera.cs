using System;
using System.Collections.Generic;

namespace PracticaMVC2.Models;

public partial class Carrera
{
    public int CarreraId { get; set; }

    public string? NombreCarrera { get; set; }

    public int? FacultadId { get; set; }
}
