
namespace TuProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarMensajeBienvenida();

            bool running = true;

            while (running)
            {
                Console.Clear();
                MostrarMenu();

                try
                {
                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Agregando nuevo Ticket...");
                            // Lógica para agregar un nuevo Ticket
                            Console.WriteLine("Nuevo Ticket agregado exitosamente.");
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("Buscando Ticket por Id...");
                            // Lógica para buscar un Ticket por Id
                            Console.WriteLine("Ticket encontrado.");
                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("Actualizando Ticket...");
                            // Lógica para actualizar un Ticket
                            Console.WriteLine("Ticket actualizado exitosamente.");
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("Eliminando Ticket por Id...");
                            // Lógica para eliminar un Ticket por Id
                            Console.WriteLine("Ticket eliminado exitosamente.");
                            break;
                        case "5":
                            Console.Clear();
                            Console.WriteLine("Listando todos los Tickets...");
                            // Lógica para listar todos los Tickets
                            Console.WriteLine("Listado de Tickets:");
                            break;
                        case "6":
                            Console.Clear();
                            Console.WriteLine("Realizando búsqueda avanzada...");
                            // Lógica para búsqueda avanzada de Tickets
                            Console.WriteLine("Búsqueda avanzada completada.");
                            break;
                        case "0":
                            running = false;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Opción no válida. Por favor, selecciona una opción válida.");
                            break;
                    }

                    if (running)
                    {
                        Console.WriteLine("\nPresiona ENTER para volver al menú.");
                        Console.ReadLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine($"Ha ocurrido un error: {ex.Message}");
                }
            }

            MostrarMensajeDespedida();
        }

        static void MostrarMensajeBienvenida()
        {
            Console.WriteLine("¡Bienvenido a la aplicación de administración de Tickets!");
            Console.WriteLine("\nPresiona ENTER para continuar...");
            Console.ReadLine();
        }

        static void MostrarMensajeDespedida()
        {
            Console.Clear();
            Console.WriteLine("¡Gracias por usar nuestra aplicación!");
            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();
        }

        static void MostrarMenu()
        {
            Console.WriteLine("=== Menú de Opciones ===");
            Console.WriteLine("1. Agregar nuevo Ticket");
            Console.WriteLine("2. Buscar Ticket por Id");
            Console.WriteLine("3. Actualizar Ticket");
            Console.WriteLine("4. Eliminar Ticket por Id");
            Console.WriteLine("5. Listar todos los tickets");
            Console.WriteLine("6. Búsqueda avanzada");
            Console.WriteLine("0. Salir");
            Console.Write("Selecciona una opción: ");
        }
    }
}




