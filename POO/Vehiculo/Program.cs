// See https://aka.ms/new-console-template for more information

class Vehiculo
{
    public string Marca;
    public string Modelo;
    public Vehiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }
    protected void MostrarDetalles()
    {
        Console.WriteLine($"Marca {Marca}, Modelo: {Modelo}");
    }

}
class Coche : Vehiculo
{
    public int NumeroDePuertas;
    public Coche(string marca, string modelo, int numeroDePuertas):base(marca, modelo)
    {
        NumeroDePuertas = numeroDePuertas;
    }
    public void MostrarDetallesCoche()
    {
        Console.WriteLine($"Marca {Marca}, Modelo: {Modelo}, Numero de puertas: {NumeroDePuertas}");
    }
}
class Program
{
    static void  Main()
    {
        Coche coche = new Coche("Ford", "f-250", 4);
       // coche.MostrarDetalles();
        coche.MostrarDetallesCoche();

    }
}