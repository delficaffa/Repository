using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1POO
{
    interface IDatosEmpleados
    {
        string Nombre { get; set; }

        string Apellido { get; set; }

        int AnioIngreso { get; set; }

        string Dni { get; set; }

        decimal PrecioPorHora { get; set; }

        decimal HorasTrabajadas { get; set; }

        int CalcularAntiguedad();

        decimal CalcularTasaAntiguedad();

        

    }
}
