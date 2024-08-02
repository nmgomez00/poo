// See https://aka.ms/new-console-template for more information
//Empleado tiempo completo, empleado medio tiempo, nombre,salario,calcular salario()
//
//Console.WriteLine($"Salario de {radio.Marca}:{Muchisimo}"}
//abstract class Empleado
abstract class Empleado
{
    public string Nombre { get; set; }
    public double Salario { get; set; }

    public Empleado(string nombre, double salario)
    {
        Nombre = nombre;
        Salario = salario;
    }

    public abstract double CalcularSalario();
}
class EmpleadoTiempoCompleto : Empleado
{
    public EmpleadoTiempoCompleto(string nombre, int salario) : base(nombre, salario)
    {

    }
    public override double CalcularSalario()
    {
        return Salario;
    }
}
class EmpleadoMedioTiempo : Empleado
{
    public EmpleadoMedioTiempo(string nombre, int salario) : base(nombre, salario)
    {

    }
    public override double CalcularSalario()
    {
        return Salario * 0.5;
    }
}

class Program
{
    static void Main()
    {

        Empleado EmpleadoTiempoCompleto = new EmpleadoTiempoCompleto("Nicolas", 500000);
        Empleado EmpleadoMedioTiempo = new EmpleadoMedioTiempo("pepe", 500000);
        Console.WriteLine($"Salario de {EmpleadoTiempoCompleto.Nombre}:{EmpleadoTiempoCompleto.CalcularSalario()}");
        Console.WriteLine($"Salario de { EmpleadoMedioTiempo.Nombre}:{ EmpleadoMedioTiempo.CalcularSalario()}");
        Console.ReadLine();
    }
}