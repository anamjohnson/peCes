using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

// Definición de la clase Ticket
public class Ticket
{
    public int Id { get; set; }
    public Cliente? Cliente { get; set; }
    public string? Producto { get; set; }
    public string? Descripcion { get; set; }
    public string? Estado { get; set; }
    private readonly DateTime _createdAt;

    // Constructor de la clase Ticket
    public Ticket(int id, Cliente cliente, string producto, string descripcion, string estado)
    {
        Id = id;
        Cliente = cliente;
        Producto = producto;
        Descripcion = descripcion;
        Estado = estado;
        _createdAt = DateTime.Now; // Asignación automática al momento de la creación del objeto
    }

    // Método para obtener la información completa del ticket, incluyendo la del cliente asociado
    public string Informacion()
    {
        string clienteInfo = Cliente != null ? Cliente.Informacion() : "Cliente no especificado";

        return $"ID del Ticket: {Id}\n" +
               $"Cliente: {clienteInfo}\n" +
               $"Producto: {Producto}\n" +
               $"Descripción: {Descripcion}\n" +
               $"Estado: {Estado}\n" +
               $"Fecha de creación: {_createdAt}";
    }
}

