using System;

namespace Proyecto6_Tareas
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDoble lista = new ListaDoble();
            int opcion;

            do
            {
                Console.WriteLine("\n--- GESTOR DE TAREAS ---");
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Buscar tarea");
                Console.WriteLine("3. Mostrar tareas");
                Console.WriteLine("4. Salir");
                Console.Write("Opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("ID: ");
                        int id = int.Parse(Console.ReadLine());

                        Console.Write("Descripción: ");
                        string descripcion = Console.ReadLine();

                        lista.Insertar(new Tarea(id, descripcion));
                        Console.WriteLine("Tarea agregada.");
                        break;

                    case 2:
                        Console.Write("Ingrese ID: ");
                        int buscar = int.Parse(Console.ReadLine());

                        Tarea tarea = lista.Buscar(buscar);

                        if (tarea != null)
                            Console.WriteLine(tarea);
                        else
                            Console.WriteLine("Tarea no encontrada.");

                        break;

                    case 3:
                        lista.Mostrar();
                        break;

                    case 4:
                        Console.WriteLine("Fin del programa.");
                        break;

                    default:
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }

            } while (opcion != 4);
        }
    }
}