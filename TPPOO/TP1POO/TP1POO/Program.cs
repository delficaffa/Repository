using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1POO
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;

            do
            {
                Console.WriteLine("Ingrese la opcion deseada");
                Console.WriteLine("'S' - Supervisores  'V' - Vendedores   'M' - Mejores pagos   'E' - SALIR");
                opcion = Console.ReadLine();

                switch (opcion.ToLower())
                {
                    case "s":
                        MenuSupervisores();
                        break;

                    case "v":
                        MenuVendedores();
                        break;

                    case "m":
                        MejorPagoVen();
                        MejorPagoSup();

                        break;
                }
            } while (opcion != "e");

            Console.WriteLine("Fin del programa, ingrese una tecla para continuar");
            Console.ReadLine();


        }

        private static void MenuVendedores()
        {

            Console.WriteLine("Listado 'l' Consultar 'c' Agregar 'a' Modificar 'm' Eliminar 'e'");
            var opcion = Console.ReadLine();

            switch (opcion.ToLower())
            {
                case "l":
                    var vendedores = BaseDeDatos.Vendedores;
                    Console.WriteLine("Vendedores : ");
                    foreach (var v in vendedores)
                    {
                        MostrarVendedor(v);
                    }

                    break;

                case "c":
                    Console.WriteLine("Ingrese el dni a buscar");
                    var dniParaBuscar = Console.ReadLine();

                    Vendedor vendedor = null;

                    foreach (var v in BaseDeDatos.Vendedores)
                    {
                        if (v.Dni == dniParaBuscar)
                        {
                            vendedor = v;
                            break;
                        }
                    }

                    if (vendedor != null)
                    {
                        MostrarVendedor(vendedor);
                    }
                    else
                    {
                        Console.WriteLine($"No existe el vendedor con el dni: {dniParaBuscar}");
                    }

                    break;

                case "a":
                    Console.WriteLine("Ingrese nombre");
                    var nuevoVendedorNombre = Console.ReadLine();

                    Console.WriteLine("Ingrese apellido");
                    var nuevoVendedorApellido = Console.ReadLine();

                    Console.WriteLine("Ingrese Año de ingreso");
                    int.TryParse(Console.ReadLine(), out var nuevoVendedorAnioIngreso);

                    Console.WriteLine("Ingrese dni");
                    var nuevoVendedorDni = Console.ReadLine();

                    Console.WriteLine("Ingrese precio por hora");
                    int.TryParse(Console.ReadLine(), out var nuevoVendedorPrecioPorHora);

                    Console.WriteLine("Ingrese horas trabajadas");
                    int.TryParse(Console.ReadLine(), out var nuevoVendedorHorasTrabajadas);

                    var nuevoVendedor = new Vendedor
                    {
                        Apellido = nuevoVendedorApellido,
                        Nombre = nuevoVendedorNombre,
                        AnioIngreso = nuevoVendedorAnioIngreso,
                        Dni = nuevoVendedorDni,
                        PrecioPorHora = nuevoVendedorPrecioPorHora,
                        HorasTrabajadas = nuevoVendedorHorasTrabajadas
                    };

                    BaseDeDatos.Vendedores.Add(nuevoVendedor);
                    Console.WriteLine("Vendedor agregado correctamente");
                    break;

                case "m":
                    Console.WriteLine("Ingrese el dni a buscar");
                    var dniParaEditar = Console.ReadLine();

                    Vendedor vendedorParaEditar = null;

                    foreach (var v in BaseDeDatos.Vendedores)
                    {
                        if (v.Dni == dniParaEditar)
                        {
                            vendedorParaEditar = v;
                            break;
                        }
                    }

                    if (vendedorParaEditar != null)
                    {
                        Console.WriteLine("Ingrese nuevo nombre");
                        var editarVendedorNombre = Console.ReadLine();

                        Console.WriteLine("Ingrese nuevo apellido");
                        var editarVendedorApellido = Console.ReadLine();

                        Console.WriteLine("Ingrese nuevo Año de ingreso");
                        int.TryParse(Console.ReadLine(), out var editarVendedorAnioIngreso);

                        Console.WriteLine("Ingrese nuevo dni");
                        var editarVendedorDni = Console.ReadLine();

                        Console.WriteLine("Ingrese nuevo precio por hora");
                        int.TryParse(Console.ReadLine(), out var editarVendedorPrecioPorHora);

                        Console.WriteLine("Ingrese nuevas horas trabajadas");
                        int.TryParse(Console.ReadLine(), out var editarVendedorHorasTrabajadas);

                        vendedorParaEditar.Apellido = editarVendedorApellido;
                        vendedorParaEditar.Nombre = editarVendedorNombre;
                        vendedorParaEditar.AnioIngreso = editarVendedorAnioIngreso;
                        vendedorParaEditar.Dni = editarVendedorDni;
                        vendedorParaEditar.PrecioPorHora = editarVendedorPrecioPorHora;
                        vendedorParaEditar.HorasTrabajadas = editarVendedorHorasTrabajadas;

                        Console.WriteLine("Vendedor editado correctamente");
                    }
                    else
                    {
                        Console.WriteLine($"No existe el vendedor con el dni: {dniParaEditar}");
                    }
                    break;

                case "e":
                    Console.WriteLine("Ingrese el dni a buscar");
                    var dniParaRemover = Console.ReadLine();

                    Vendedor vendedorParaRemover = null;

                    foreach (var v in BaseDeDatos.Vendedores)
                    {
                        if (v.Dni == dniParaRemover)
                        {
                            vendedorParaRemover = v;
                            break;
                        }
                    }

                    if (vendedorParaRemover != null)
                    {
                        BaseDeDatos.Vendedores.Remove(vendedorParaRemover);

                        Console.WriteLine("Vendedor eliminado correctamente");
                    }
                    else
                    {
                        Console.WriteLine($"No existe el vendedor con el dni: {dniParaRemover}");
                    }

                    break;
            }

            opcion = Console.ReadLine();

        }

        private static void MenuSupervisores()
        {

            Console.WriteLine("Listado 'l' Consultar 'c' Agregar 'a' Modificar 'm' Eliminar 'e'");
            var opcion = Console.ReadLine();

            switch (opcion.ToLower())
            {
                case "l":
                    var supervisores = BaseDeDatos.Supervisores;
                    Console.WriteLine("Supervisores : ");
                    foreach (var s in supervisores)
                    {
                        MostrarSupervisor(s);
                    }

                    break;

                case "c":
                    Console.WriteLine("Ingrese el dni a buscar");
                    var dniParaBuscar = Console.ReadLine();

                    Supervisor supervisor = null;

                    foreach (var s in BaseDeDatos.Supervisores)
                    {
                        if (s.Dni == dniParaBuscar)
                        {
                            supervisor = s;
                            break;
                        }
                    }

                    if (supervisor != null)
                    {
                        MostrarSupervisor(supervisor);
                    }
                    else
                    {
                        Console.WriteLine($"No existe el supervisor con el dni: {dniParaBuscar}");
                    }

                    break;

                case "a":
                    Console.WriteLine("Ingrese nombre");
                    var nuevoSupervisorNombre = Console.ReadLine();

                    Console.WriteLine("Ingrese apellido");
                    var nuevoSupervisorApellido = Console.ReadLine();

                    Console.WriteLine("Ingrese Año de ingreso");
                    int.TryParse(Console.ReadLine(), out var nuevoSupervisorAnioIngreso);

                    Console.WriteLine("Ingrese dni");
                    var nuevoSupervisorDni = Console.ReadLine();

                    Console.WriteLine("Ingrese categoria");
                    var nuevoSupervisorCategoria = Console.ReadLine().ToLower();

                    Console.WriteLine("Ingrese precio por hora");
                    int.TryParse(Console.ReadLine(), out var nuevoSupervisorPrecioPorHora);

                    Console.WriteLine("Ingrese horas trabajadas");
                    int.TryParse(Console.ReadLine(), out var nuevoSupervisorHorasTrabajadas);

                    var nuevoSupervisor = new Supervisor
                    {
                        Apellido = nuevoSupervisorApellido,
                        Nombre = nuevoSupervisorNombre,
                        AnioIngreso = nuevoSupervisorAnioIngreso,
                        Dni = nuevoSupervisorDni,
                        PrecioPorHora = nuevoSupervisorPrecioPorHora,
                        HorasTrabajadas = nuevoSupervisorHorasTrabajadas,
                        Categoria = nuevoSupervisorCategoria
                    };

                    BaseDeDatos.Supervisores.Add(nuevoSupervisor);
                    Console.WriteLine("Supervisor agregado correctamente");
                    break;

                case "m":
                    Console.WriteLine("Ingrese el dni a buscar");
                    var dniParaEditar = Console.ReadLine();

                    Supervisor supervisorParaEditar = null;

                    foreach (var s in BaseDeDatos.Supervisores)
                    {
                        if (s.Dni == dniParaEditar)
                        {
                            supervisorParaEditar = s;
                            break;
                        }
                    }

                    if (supervisorParaEditar != null)
                    {
                        Console.WriteLine("Ingrese nuevo nombre");
                        var editarSupervisorNombre = Console.ReadLine();

                        Console.WriteLine("Ingrese nuevo apellido");
                        var editarSupervisorApellido = Console.ReadLine();

                        Console.WriteLine("Ingrese nuevo Año de ingreso");
                        int.TryParse(Console.ReadLine(), out var editarSupervisorAnioIngreso);

                        Console.WriteLine("Ingrese nuevo dni");
                        var editarSupervisorDni = Console.ReadLine();

                        Console.WriteLine("Ingrese nueva categoria");
                        var editarSupervisorCategoria = Console.ReadLine().ToLower();

                        Console.WriteLine("Ingrese nuevo precio por hora");
                        int.TryParse(Console.ReadLine(), out var editarSupervisorPrecioPorHora);

                        Console.WriteLine("Ingrese nuevas horas trabajadas");
                        int.TryParse(Console.ReadLine(), out var editarSupervisorHorasTrabajadas);

                        supervisorParaEditar.Apellido = editarSupervisorApellido;
                        supervisorParaEditar.Nombre = editarSupervisorNombre;
                        supervisorParaEditar.AnioIngreso = editarSupervisorAnioIngreso;
                        supervisorParaEditar.Dni = editarSupervisorDni;
                        supervisorParaEditar.PrecioPorHora = editarSupervisorPrecioPorHora;
                        supervisorParaEditar.HorasTrabajadas = editarSupervisorHorasTrabajadas;
                        supervisorParaEditar.Categoria = editarSupervisorCategoria;

                        Console.WriteLine("Supervisor editado correctamente");
                    }
                    else
                    {
                        Console.WriteLine($"No existe el supervisor con el dni: {dniParaEditar}");
                    }
                    break;

                case "e":
                    Console.WriteLine("Ingrese el dni a buscar");
                    var dniParaRemover = Console.ReadLine();

                    Supervisor supervisorParaRemover = null;

                    foreach (var s in BaseDeDatos.Supervisores)
                    {
                        if (s.Dni == dniParaRemover)
                        {
                            supervisorParaRemover = s;
                            break;
                        }
                    }

                    if (supervisorParaRemover != null)
                    {
                        BaseDeDatos.Supervisores.Remove(supervisorParaRemover);

                        Console.WriteLine("Supervisor eliminado correctamente");
                    }
                    else
                    {
                        Console.WriteLine($"No existe el supervisor con el dni: {dniParaRemover}");
                    }

                    break;
            }

            opcion = Console.ReadLine();

        }

        private static void MostrarSupervisor(Supervisor s)
        {

            Console.WriteLine($"Apellido: {s.Apellido}\nNombre: {s.Nombre}\nAño de Ingreso: {s.AnioIngreso}" +
                $"\nDNI: {s.Dni}\nCategoria: {s.Categoria}\nSueldo Total: {s.CalculoSueldoTotal()}");
            Console.WriteLine(" ");
        }

        private static void MostrarVendedor(Vendedor v)
        {
            Console.WriteLine($"Apellido: {v.Apellido}\nNombre: {v.Nombre}\nAño de Ingreso: {v.AnioIngreso}" +
                $"\nDNI: {v.Dni}\nSueldo total: {v.CalculoSueldoTotal()}");
            Console.WriteLine(" ");
        }



        private static void MejorPagoSup()
        {
            var supervisores = BaseDeDatos.Supervisores;
            var maxSup = supervisores.OrderByDescending(
                a => a.CalculoSueldoTotal()).First();

            Console.WriteLine($"Supervisor Mejor Pago:\n\t {maxSup.Apellido}, {maxSup.Nombre}: ${maxSup.CalculoSueldoTotal()}");
        }

        private static void MejorPagoVen()
        {
            var vendedores = BaseDeDatos.Vendedores;
            var maxVen = vendedores.OrderByDescending(
                v => v.CalculoSueldoTotal()).First();
            Console.WriteLine($"Vendedor Mejor Pago:\n\t {maxVen.Apellido}, {maxVen.Nombre}: ${maxVen.CalculoSueldoTotal()}");
        }

    }
}
