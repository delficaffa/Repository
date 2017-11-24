namespace Day4
{
    public class Estudiante : Persona
    {
        public string Legajo { get; set; }

        public override string Presentacion()
        {
            return $"Hola soy un estudiante {Apellido} {Nombre} legajo : {Legajo}";
        }
    }

    public class profesor : Persona
    {
        public string Materia { get; set; }

        public string Dni { get; set; }

        public override string Presentacion()
        {
            return $"Hola soy el profesor {this.Apellido} {this.Nombre} de la materia {this.Materia}";
        }
    }
}