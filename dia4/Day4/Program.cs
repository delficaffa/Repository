using System;

namespace Day4
{
    public class Program
    {
        static void Main(string[] args)
        {
            string opcion;

            do
            {
                LINEA();
                Console.WriteLine("Ingrese la opcion deseada 'p' Profesores - 'e' Estudiantes, 's' Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "p":
                        ejecutarMenuProfesores();
                        break;

                    case "e":
                        ejecutarMenuEstudiantes();
                        break;
                }
            } while (opcion != "s");

            LINEA();
            Console.WriteLine("Fin del programa, ingrese una tecla para continuar");
            Console.ReadLine();
        }

        private static void ejecutarMenuEstudiantes()
        {
            throw new NotImplementedException();
        }

        private static void ejecutarMenuProfesores()
        {
            LINEA();
            Console.WriteLine("Listado 'l' Consultar 'c' Agregar 'a' Modificar 'm' Eliminar 'e'");
            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "l":
                    var profesores = BaseDeDatos.Profesores;
                    LINEA();
                    Console.WriteLine("Profesores : ");
                    foreach (var p in profesores)
                    {
                        Mostrar_profesor(p);
                    }

                    break;

                case "c":
                    LINEA();
                    Console.WriteLine("Ingrese el dni a buscar");
                    var dniParaBuscar = Console.ReadLine();

                    profesor profesor = null;

                    foreach (var p in BaseDeDatos.Profesores)
                    {
                        if (p.Dni == dniParaBuscar)
                        {
                            profesor = p;
                            break;
                        }
                    }

                    if (profesor != null)
                    {
                        Mostrar_profesor(profesor);
                    }
                    else
                    {
                        Console.WriteLine("No existe el profesor ingresado");
                    }

                    break;

                case "a":
                    LINEA();
                    Console.WriteLine("Ingrese nombre");
                    var nuevoProfesorNombre = Console.ReadLine();

                    Console.WriteLine("Ingrese apellido");
                    var nuevoProfesorApellido = Console.ReadLine();

                    Console.WriteLine("Ingrese dni");
                    var nuevoProfesorDni = Console.ReadLine();

                    Console.WriteLine("Ingrese materia");
                    var nuevoProfesorMateria = Console.ReadLine();

                    var nuevoProfesor = new profesor
                    {
                        Apellido = nuevoProfesorApellido,
                        Dni = nuevoProfesorDni,
                        Nombre = nuevoProfesorNombre,
                        Materia = nuevoProfesorMateria
                    };

                    BaseDeDatos.Profesores.Add(nuevoProfesor);
                    LINEA();
                    Console.WriteLine("Profesor agregado correctamente");
                    break;

                case "m":
                    LINEA();
                    Console.WriteLine("Ingrese el dni a buscar");
                    var dniParaEditar = Console.ReadLine();

                    profesor profesorParaEditar = null;

                    foreach (var p in BaseDeDatos.Profesores)
                    {
                        if (p.Dni == dniParaEditar)
                        {
                            profesorParaEditar = p;
                            break;
                        }
                    }

                    if (profesorParaEditar != null)
                    {
                        LINEA();
                        Console.WriteLine("Ingrese nuevo nombre");
                        var editarProfesorNombre = Console.ReadLine();

                        Console.WriteLine("Ingrese nuevo apellido");
                        var editarProfesorApellido = Console.ReadLine();

                        Console.WriteLine("Ingrese nuevo dni");
                        var editarProfesorDni = Console.ReadLine();

                        Console.WriteLine("Ingrese nueva materia");
                        var editarProfesorMateria = Console.ReadLine();

                        profesorParaEditar.Nombre = editarProfesorNombre;
                        profesorParaEditar.Apellido = editarProfesorApellido;
                        profesorParaEditar.Dni = editarProfesorDni;
                        profesorParaEditar.Materia = editarProfesorMateria;

                        LINEA();
                        Console.WriteLine("Profesor editado correctamente");
                    }
                    else
                    {
                        Console.WriteLine("No existe el profesor ingresado");
                    }
                    break;

                case "e":
                    LINEA();
                    Console.WriteLine("Ingrese el dni a buscar");
                    var dniParaRemover = Console.ReadLine();

                    profesor profesorParaRemover = null;

                    foreach (var p in BaseDeDatos.Profesores)
                    {
                        if (p.Dni == dniParaRemover)
                        {
                            profesorParaRemover = p;
                            break;
                        }
                    }

                    if (profesorParaRemover != null)
                    {
                        BaseDeDatos.Profesores.Remove(profesorParaRemover);

                        LINEA();
                        Console.WriteLine("Profesor eliminado correctamente");
                    }
                    else
                    {
                        Console.WriteLine("No existe el profesor ingresado");
                    }

                    break;
            }

            opcion = Console.ReadLine();
        }

        private static void Mostrar_profesor(profesor p)
        {
            Console.WriteLine($" Nombre : {p.Nombre}, Apellido : {p.Apellido}, Materia : {p.Materia}");
        }

        private static void LINEA()
        {
            Console.WriteLine("======================");
        }
    }
}