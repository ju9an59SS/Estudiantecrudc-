using System;

namespace Est

{
    public class Estudiante
    {
        private string nombre;
        private string apellido;
        private int edad;
        private int id;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Estudiante()
        {
        }
    }
}
