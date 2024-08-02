using System.Transactions;

abstract class Vehiculo//no se instancia
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public Vehiculo(string marca, string modelo)//el contructor siempre tiene que estar
    {
        Marca = marca;
        Modelo = modelo;
    }
    //sobrecarga de constructores

    public abstract void Conducir();//no se la que va ser, se tiene que implementar
}
class Auto : Vehiculo
{
    //  public string Patente { get; set; }
    public Auto(string marca, string modelo/*string patente*/) : base(marca, modelo)
    {
        // Patente = patente;
    }
    public override void Conducir() //p
    {
        Console.WriteLine($"Conduciondo la moto {Marca} {Modelo}.");
    }

}
class Moto : Vehiculo
{
    public Moto(string marca, string modelo/*string patente*/) : base(marca, modelo)
    {

    }
    public override void Conducir()
    {
        Console.WriteLine($"Conduciondo la moto {Marca} {Modelo}.");
    }

}
class Program
{
    static void Main()
    {
        Vehiculo auto = new Auto("Toyota", "Hilux");

        auto.Conducir();
        Vehiculo moto = new Moto("Yamaha", "MT-07");

        moto.Conducir();

    }
}
