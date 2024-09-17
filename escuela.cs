using System;
using System.Collections.Generic;
using System.Linq;

namespace Est
{
    public class Escuela
    {
        /* Lista que será del tipo de la clase Estudiante
           Alojara objetos del tipo de esa clase */
        private List<Estudiante> estudiantes;

        public Escuela()
        {
            estudiantes = new List<Estudiante>();
        }

        /* Se agregan un nuevo objeto a la lista */
        public void AgregarEstudiante(Estudiante nuevoEstudiante)
        {
            estudiantes.Add(nuevoEstudiante);
        }

        /* Imprimimos cada objeto con sus respectivas propiedades
           que hacen referencia a los atributos */
        public void MostrarEstudiantes()
        {
            Console.WriteLine("\t\tEstudiantes ingresados");

            foreach (var e in estudiantes)
            {
                Console.WriteLine($"\n\nId: {e.Id}");
                Console.WriteLine($"Nombre completo: {e.Nombre} {e.Apellido}");
                Console.WriteLine($"Edad: {e.Edad}");
                Console.WriteLine("\n");
            }
        }

        /* Método que encuentra estudiantes por nombre */
        public void BuscarEstudiante(string nombre)
        {
            var estudiantesEncontrados = estudiantes
                .Where(e => e.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (!estudiantesEncontrados.Any())
            {
                Console.WriteLine("\nNo se encontró el estudiante");
                return;
            }

            foreach (var e in estudiantesEncontrados)
            {
                Console.WriteLine($"\nId: {e.Id}");
                Console.WriteLine($"Nombre completo: {e.Nombre} {e.Apellido}");
                Console.WriteLine($"Edad: {e.Edad}");
                Console.WriteLine("\n");
            }
        }

        /* Pide un id, este se evalúa si coincide con el id de alguno de
           los objetos en la lista estudiantes. Si es así, obtiene el objeto
           y lo pasa a la variable element, que es un objeto en sí y se remueve.
           Luego si es correcto el remove envía true hacia la clase Program */
        public bool EliminarEstudiante(int id)
        {
            var elemento = estudiantes.Find(e => e.Id == id);
            return estudiantes.Remove(elemento);
        }

        /* Pide un objeto con los datos del usuario a actualizar
           Luego evalúa si el id de ese objeto coincide con alguno de la lista 
           estudiantes. Si es así, obtiene el objeto y se le van pasando los valores
           del objeto que se ha pedido al usuario para actualizar */
        public void ActualizarEstudiante(Estudiante estudianteActualizado)
        {
            var elemento = estudiantes.Find(e => e.Id == estudianteActualizado.Id);
            if (elemento != null)
            {
                elemento.Nombre = estudianteActualizado.Nombre;
                elemento.Apellido = estudianteActualizado.Apellido;
                elemento.Edad = estudianteActualizado.Edad;

                Console.WriteLine("\nActualización exitosa");
            }
            else
            {
                Console.WriteLine("\nNo se pudo actualizar el registro");
            }
        }
    }
}
