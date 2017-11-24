using System.Collections.Generic;

namespace Day4
{
    public static class BaseDeDatos
    {
        public static List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>
        {
            new Estudiante
            {
                Apellido = "Revoledo",
                Legajo = "40608",
                Nombre = "David"
            },
            new Estudiante
            {
                Apellido = "Araujo",
                Legajo = "23331",
                Nombre = "Cesar"
            }
        };

        public static List<profesor> Profesores { get; set; } = new List<profesor>
        {
            new profesor
            {
                Apellido = "Revoledo",
                Materia = ".Net",
                Nombre = "David",
                Dni = "35444444"
            }
        };
    }
}