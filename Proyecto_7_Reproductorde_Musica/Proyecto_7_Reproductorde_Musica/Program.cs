//Santos Zahid Zavala Ramirez
//Unidad 3 
//Estructura de Datos

using System;
using System.Runtime.InteropServices;

namespace Proyecto7_Musica
{
    internal class Program
    {
        static ListaCircular playlist =
            new ListaCircular();

        static void Main()
        {
            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("=== REPRODUCTOR===");
                Console.WriteLine("1.Agregar canción");
                Console.WriteLine("2.Siguiente");
                Console.WriteLine("3.Mostrar playlist");

                Console.WriteLine("0.Salir");

                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("Canción");
                        string nombre = Console.ReadLine();

                        Console.Write("Artista");
                        string artista = Console.ReadLine();
                        playlist.Agregar(new Cancion(nombre, artista));

                        break;

                    case 2:
                        playlist.Siguiente();
                        Console.ReadKey();
                        break; 
                    
                    case 3:
                        playlist.Mostrar();
                        Console.ReadKey();
                        break;

                
                }

            } while(opcion!=0);
        }
         
    }
}