using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Definición de la clase PersonaNatural que hereda de Cliente
public class PersonaNatural : Cliente
{
    public string? Dni { get; set; }

    // Constructor de la clase PersonaNatural
    public PersonaNatural(string id, string nombre, string rut, string telefono, string email, string dni)
    {
        Id = id;
        Nombre = nombre;
        Rut = rut;
        Telefono = telefono;
        Email = email;
        Dni = dni;
    }

    // Sobrescribe el método Informacion de Cliente para incluir el DNI
    public override string Informacion()
    {
        return base.Informacion() + $", DNI: {Dni}";
    }
}

