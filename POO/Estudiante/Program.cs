
class Estudiante
{
    private string _nombre;
    private int _legajo;
    private double _promedio;

    public Estudiante(string nombre, int legajo, double promedio)
    {
        Nombre = nombre;
        Legajo = legajo;
        Promedio = promedio;
    }

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }
    public int Legajo
    {
        get { return _legajo; }
        set { _legajo = value; }
    }

    public double Promedio
    {
        get { return _promedio; }
        private set { _promedio = value; }
    }

    public void ActualizarPromedio(double promedio)
    {
        if (promedio >= 0 && promedio <= 10)
        {
            Promedio = promedio;
            Console.WriteLine($"El Promedio de {Nombre} es {Promedio}");
        }
        else
        {
            Console.WriteLine($"Promedio ingresado no valido");
        }

    }
}
class Program
{
    static void Main()
    {
        Estudiante estudiante = new Estudiante("Nicolas", 17852, 8);
        Console.WriteLine($"El promedio de {estudiante.Nombre} es {estudiante.Promedio}");
        estudiante.ActualizarPromedio(9);
        Console.WriteLine($"El promedio de {estudiante.Nombre} es {estudiante.Promedio}");

    }
}

