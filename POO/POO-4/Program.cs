// See https://aka.ms/new-console-template for more information
//Empleado tiempo completo, empleado medio tiempo, nombre,salario,calcular salario()
//
//Console.WriteLine($"Salario de {radio.Marca}:{Muchisimo}"}
//abstract class Empleado
abstract class Empleado
{
    public string Nombre { get; set; }
    public double  Salario {  get; set; }
    
    public Empleado(string nombre, double  salario)
    {
        Nombre = nombre;
        Salario = salario;
    }

    public abstract double CalcularSalario();
} 
class TiempoCompleto : Empleado
{
    public TiempoCompleto(string nombre, double  salario) : base(nombre, salario)
    {

    }
    public override double CalcularSalario()
    {
        return Salario;
    }
}
class MedioTiempo : Empleado
{
    public MedioTiempo(string nombre, double  salario) : base(nombre, salario)
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

        Empleado tiempoCompleto = new TiempoCompleto("Nicolas", 500000);
        Empleado medioTiempo = new MedioTiempo("pepe", 500000);
        Console.WriteLine($"Salario de {tiempoCompleto.Nombre}:{tiempoCompleto.CalcularSalario()}");
        Console.WriteLine($"Salario de {medioTiempo.Nombre}:{medioTiempo.CalcularSalario()}");
        Console.ReadLine();
    }
}