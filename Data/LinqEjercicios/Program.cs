using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace LinqEjercicios
{/*
    A partir del objeto DataContext del proyecto DataToTestLinq, realizar las siguientes consultas. 
 
    +- Listar todas las personas mostrando nombre, país y edad. 
    +- Listar las mujeres. 
    +- Listar los hombres que pesen más de 70KG. 
    +- Promedio de edad de las personas de la lista, sin incluir a sus hijos. 
    +- Listar los hijos de cada persona. 
    +- Promedio de edad por país.
    +- Promedio de peso por género. 
    - Persona con mayor peso. 
    - Persona con menor peso. 
    - Última persona de la lista. 
    - Listar personas que hablan más de un idioma mostrando el nombre y los idiomas que habla. 
    - Promedio de edad de los hijos de cada persona. - Consultar si existe alguna persona llamada “Osvaldo”. 
    - Ordenar las personas por edad y listar las personas en 3ra y 4ta posición.
     */
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*** TODAS LAS PERSONAS ***");
            var servicio = new Consultas();
            var personas = servicio.Todas();
            foreach (var p in personas)
            {
                Console.WriteLine($"Nombre: {p.Name}, \tPais: {p.Country}, \tAño: {p.Age}");

            }
            Console.WriteLine("");
            Console.WriteLine("*** TODAS LAS MUJERES ***");
            Console.WriteLine("");
            var mujeres = servicio.Mujeres();
            foreach (var x in mujeres)
            {
                Console.WriteLine($"Nombre: {x.Name}");

            }
            Console.WriteLine("");
            Console.WriteLine("*** HOMBRES MAYORES A 70kg ***");
            Console.WriteLine("");
            var hombresPeso = servicio.HombresPeso();
            foreach (var x in hombresPeso)
            {
                Console.WriteLine($"Nombre: {x.Name} \tPeso: {x.Weight}");
            }
            Console.WriteLine("");
            Console.WriteLine("*** PROMEDIO DE EDADES ***");
            var prom = servicio.PromEdad();
            Console.WriteLine($"promedio de edades : {prom}");
            Console.WriteLine("");
            Console.WriteLine("*** HIJOS ***");
            var hijos = servicio.Hijos();
            foreach (var x in hijos)
            {
                Console.WriteLine($"Nombre: {x.Name}");
            }
            Console.WriteLine("");
            Console.WriteLine("*** PROMEDIO DE EDADES POR PAISES ***");
            var promP = servicio.PromEdadPais();
            foreach (var item in promP)
            {
                Console.WriteLine($" {item.Country} = {item.Avg}");
            }
            Console.WriteLine("");
            Console.WriteLine("*** PROMEDIO DE PESO POR GENERO ***");
            var promPG = servicio.PromPesoGenero();
            foreach (var item in promPG)
            {
                Console.WriteLine($" {item.Gender} = {item.Avg}");
            }
            Console.WriteLine("");
            Console.WriteLine("*** MAS PESADO ***");
            var masP = servicio.MasPesado();
            Console.WriteLine($" Nombre: {masP.Name}\tPeso: {masP.Weight}");


            Console.ReadLine();
        }








    }
}
