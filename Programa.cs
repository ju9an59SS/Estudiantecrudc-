using System;

namespace Est
{
    class Programa
    {
        static void Main(string[] args)
        {
            bool respuesta = false;
            Escuela escuela = new Escuela();

            do
            {
                int opcion;

                Console.WriteLine("\n\tREGISTRO DE ESTUDIANTES ");
                Console.WriteLine("\n1-Agregar estudiante");
                Console.WriteLine("2-Mostrar estudiantes");
                Console.WriteLine("3-Buscar estudiante por nombre");
                Console.WriteLine("4-Editar estudiante");
                Console.WriteLine("5-Eliminar estudiante");
                Console.WriteLine("6-Salir");
                Console.Write("\nEscoja una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Estudiante estudiante = new Estudiante();
                        Console.Write("\nDigite el id: ");
                        estudiante.Id = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Digite nombre: ");
                        estudiante.Nombre = Console.ReadLine();
                        Console.Write("Digite apellido: ");
                        estudiante.Apellido = Console.ReadLine();
                        Console.Write("Digite la edad: ");
                        estudiante.Edad = Convert.ToInt16(Console.ReadLine());

                        escuela.AgregarEstudiante(estudiante);
                        Console.Clear();
                        break;

                    case 2:
                        escuela.MostrarEstudiantes();
                        break;

                    case 3:
                        string nombre;
                        Console.Write("\nIngrese el nombre a buscar: ");
                        nombre = Console.ReadLine();

                        escuela.BuscarEstudiante(nombre);
                        break;

                    case 4:
                        Estudiante estudianteActualizar = new Estudiante();
                        Console.Write("\nDigite los datos del estudiante a editar");
                        Console.Write("\n\nDigite el id: ");
                        estudianteActualizar.Id = Convert.ToInt16(Console.ReadLine());
                        Console.Write("Digite nombre: ");
                        estudianteActualizar.Nombre = Console.ReadLine();
                        Console.Write("Digite apellido: ");
                        estudianteActualizar.Apellido = Console.ReadLine();
                        Console.Write("Digite la edad: ");
                        estudianteActualizar.Edad = Convert.ToInt16(Console.ReadLine());

                        escuela.ActualizarEstudiante(estudianteActualizar);
                        break;

                    case 5:
                        int id;
                        Console.Write("\nIngrese el id del estudiante a eliminar: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        bool resultado = escuela.EliminarEstudiante(id);

                        if (resultado)
                        {
                            Console.WriteLine("\nSe eliminó correctamente");
                        }
                        else
                        {
                            Console.WriteLine("\nNo se pudo eliminar el registro");
                        }
                        break;

                    case 6:
                        respuesta = true;
                        break;
                }

            } while (!respuesta);
        }
    }
}
