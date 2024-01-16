using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;

public static class TicketCollection
{
    private static List<Ticket> _listadoTickets = new();

    public static string Create(Ticket ticket)
    {
        _listadoTickets.Add(ticket);
        return "Ticket creado exitosamente.";
    }

    public static string Read(int id)
    {
        Ticket ticket = _listadoTickets.FirstOrDefault(t => t.Id == id);
        return ticket != null ? ticket.Informacion() : "Ticket no encontrado.";
    }

    public static string Update(int id, Ticket ticket)
    {
        Ticket ticketToUpdate = _listadoTickets.FirstOrDefault(t => t.Id == id);
        if (ticketToUpdate == null)
        {
            return "Ticket no encontrado para actualizar.";
        }

        // Solo se actualizan los datos del ticket de soporte
        ticketToUpdate.Producto = ticket.Producto;
        ticketToUpdate.Descripcion = ticket.Descripcion;
        ticketToUpdate.Estado = ticket.Estado;

        return "Ticket actualizado exitosamente.";
    }

    public static string Delete(int id)
    {
        Ticket ticketToDelete = _listadoTickets.FirstOrDefault(t => t.Id == id);
        if (ticketToDelete == null)
        {
            return "Ticket no encontrado para eliminar.";
        }

        _listadoTickets.Remove(ticketToDelete);
        return "Ticket eliminado exitosamente.";
    }

    public static List<Ticket> ReadAll()
    {
        return _listadoTickets;
    }

    public static List<Ticket> Search(string filter)
    {
        return _listadoTickets.Where(t =>
            (t.Cliente?.Nombre?.Contains(filter, StringComparison.OrdinalIgnoreCase) == true ||
             t.Cliente?.Rut?.Contains(filter, StringComparison.OrdinalIgnoreCase) == true ||
             t.Estado?.Contains(filter, StringComparison.OrdinalIgnoreCase) == true)
        ).ToList();
    }
}

