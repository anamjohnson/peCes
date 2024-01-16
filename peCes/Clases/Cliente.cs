using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Definición de la clase Cliente
public class Cliente
{
    public string? Id { get; set; }
    public string? Nombre { get; set; }
    public string? Rut { get; set; }
    public string? Telefono { get; set; }
    public string? Email { get; set; }

    // Método para obtener la información del cliente
    public virtual string Informacion()
    {
        return $"ID: {Id}, Nombre: {Nombre}, Rut: {Rut}, Teléfono: {Telefono}, Email: {Email}";
    }
}
