using System;
namespace Proyecto6_Tareas
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        public Tarea(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
            Estado = "Pendiente"; // Estado inicial de la tarea
        }
        public override string ToString()
        {
            return $"{Id}-{Descripcion}- {Estado})";
        }

    }
}
