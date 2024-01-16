using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Definición de la clase Empresa que hereda de Cliente
public class Empresa : Cliente
{
    public string? RazonSocial { get; set; }

    // Constructor de la clase Empresa
    public Empresa(string id, string nombre, string rut, string telefono, string email, string razonSocial)
    {
        Id = id;
        Nombre = nombre;
        Rut = rut;
        Telefono = telefono;
        Email = email;
        RazonSocial = razonSocial;
    }

    // Sobrescribe el método Informacion de Cliente para incluir la Razón Social
    public override string Informacion()
    {
        return base.Informacion() + $", Razón Social: {RazonSocial}";
    }
}

