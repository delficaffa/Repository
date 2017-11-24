using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1POO
{
    class BaseDeDatos
    {

        public static List<Supervisor> Supervisores { get; set; } = new List<Supervisor>
        {
            new Supervisor
            {
                Nombre = "Delfina",
                Apellido = "Caffa",
                AnioIngreso = 2000,
                Dni = "35115451",
                PrecioPorHora = 1000,
                HorasTrabajadas = 150,
                Categoria = "a"

    },
            new Supervisor
            {
                Nombre = "Maria",
                Apellido = "Sanchez",
                AnioIngreso = 2010,
                Dni = "39222456",
                PrecioPorHora = 500,
                HorasTrabajadas = 200,
                Categoria = "b"
            }
        };

        public static List<Vendedor> Vendedores { get; set; } = new List<Vendedor>
        {
            new Vendedor
            {
                Nombre = "Marta",
                Apellido = "Martinez",
                AnioIngreso = 2015,
                Dni = "11222333",
                PrecioPorHora = 100,
                HorasTrabajadas = 200,

            }
        };

    }
}
