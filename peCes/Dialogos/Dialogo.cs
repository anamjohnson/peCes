using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

public static class Dialogo
{
    public static void CargarDialogoCreate()
    {
        Console.Clear();
        Console.WriteLine("Cargar diálogo para crear un nuevo Ticket:");
        // Lógica para crear un nuevo Ticket con las especificaciones dadas
        // Preguntar al usuario si el cliente es de tipo PersonaNatural o Empresa
        // Crear la instancia de Cliente correspondiente según la respuesta del usuario
        // Establecer el valor de las propiedades del Ticket y agregarlo a la colección
        Console.WriteLine("Ticket creado exitosamente.");
        Console.WriteLine("Presiona cualquier tecla para volver al menú.");
        Console.ReadKey();
    }

    public static void CargarDialogoRead()
    {
        Console.Clear();
        Console.WriteLine("Cargar diálogo para leer un Ticket:");
        // Lógica para leer un Ticket específico
        // Mostrar la información del Ticket encontrado o un mensaje de error si no se encuentra
        Console.WriteLine("Presiona cualquier tecla para volver al menú.");
        Console.ReadKey();
    }

    public static void CargarDialogoUpdate()
    {
        Console.Clear();
        Console.WriteLine("Cargar diálogo para actualizar un Ticket:");
        // Lógica para actualizar un Ticket con las restricciones mencionadas
        // Mostrar mensajes y preguntas al usuario para actualizar los datos del Ticket
        Console.WriteLine("Ticket actualizado exitosamente.");
        Console.WriteLine("Presiona cualquier tecla para volver al menú.");
        Console.ReadKey();
    }

    public static void CargarDialogoDelete()
    {
        Console.Clear();
        Console.WriteLine("Cargar diálogo para eliminar un Ticket:");
        // Lógica para eliminar un Ticket con la verificación de existencia y confirmación del usuario
        Console.WriteLine("Ticket eliminado exitosamente.");
        Console.WriteLine("Presiona cualquier tecla para volver al menú.");
        Console.ReadKey();
    }

    public static void CargarDialogoReadAll()
    {
        Console.Clear();
        Console.WriteLine("Cargar diálogo para leer todos los Tickets:");
        // Lógica para leer todos los Tickets almacenados y mostrar su información
        // Mostrar la información de los Tickets o un mensaje de error si no hay registros
        Console.WriteLine("Presiona cualquier tecla para volver al menú.");
        Console.ReadKey();
    }

    public static void CargarDialogoSearch()
    {
        Console.Clear();
        Console.WriteLine("Cargar diálogo para buscar Tickets:");
        // Lógica para buscar Tickets según el filtro dado por el usuario
        // Mostrar los Tickets que coincidan con el filtro o un mensaje si no hay coincidencias
        Console.WriteLine("Presiona cualquier tecla para volver al menú.");
        Console.ReadKey();
    }
}

