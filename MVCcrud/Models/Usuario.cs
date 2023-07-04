using System;
using System.Collections.Generic;

namespace MVCcrud.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Clave { get; set; }

    public string? Correo { get; set; }

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public string? Rol { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaNac { get; set; }
}
