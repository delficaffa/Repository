using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1POO
{
    class Vendedor : IDatosEmpleados
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int AnioIngreso { get; set; }
        public string Dni { get; set; }
        public decimal PrecioPorHora { get; set; }
        public decimal HorasTrabajadas { get; set; }
        public decimal SueldoBase = 2000;

        public int CalcularAntiguedad()
        {
            return DateTime.Today.Year - AnioIngreso;
        }

        public decimal CalcularTasaAntiguedad()
        {
            decimal tasaAntiguedad = 0;
            if (CalcularAntiguedad() > 10)
            {
                tasaAntiguedad = HorasTrabajadas * (HorasTrabajadas * 5m) / 100;
            }
            else if (CalcularAntiguedad() > 5)
            {
                tasaAntiguedad = HorasTrabajadas * (HorasTrabajadas * 2.5m) / 100;
            }
            else
            {
                tasaAntiguedad = HorasTrabajadas;
            }

            return tasaAntiguedad;
        }

        public decimal CalculoSueldoTotal()
        {
            return SueldoBase + (HorasTrabajadas * PrecioPorHora) + CalcularTasaAntiguedad();
        }
    }
}
