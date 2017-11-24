using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1POO
{
    class Supervisor : IDatosEmpleados
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int AnioIngreso { get; set; }
        public string Dni { get; set; }
        public decimal PrecioPorHora { get; set; }
        public decimal HorasTrabajadas { get; set; }
        public decimal SueldoBase = 4000;
        public string Categoria;

        public int CalcularAntiguedad()
        {
            return DateTime.Today.Year - AnioIngreso;
        }

        public decimal CalcularTasaAntiguedad()
        {
            var tasaAntiguedad = 0m;
            if (CalcularAntiguedad() > 10)
            {
                tasaAntiguedad = HorasTrabajadas * (HorasTrabajadas * 10m) / 100;
            }
            else if (CalcularAntiguedad() > 5)
            {
                tasaAntiguedad = HorasTrabajadas * (HorasTrabajadas * 5m) / 100;
            }
            else
            {
                tasaAntiguedad = HorasTrabajadas;
            }

            return tasaAntiguedad;
        }

        public decimal CalcularComision(string categoria)
        {
            var comision = 0m;
            switch (categoria)
            {
                case "a":
                    return comision = HorasTrabajadas * (HorasTrabajadas * 10) / 100;

                case "b":
                    return comision = HorasTrabajadas * (HorasTrabajadas * 5) / 100;

                case "c":
                    return comision = HorasTrabajadas * (HorasTrabajadas * 2) / 100;

            }
            return default(decimal);
        }

        public decimal CalculoSueldoTotal()
        {
            return SueldoBase + (HorasTrabajadas * PrecioPorHora) + CalcularTasaAntiguedad() + CalcularComision(Categoria);
        }
    }
}
