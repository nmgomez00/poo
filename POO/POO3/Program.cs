// See https://aka.ms/new-console-template for more information
//TV,RADIO
using System.Reflection;
using System.Text.RegularExpressions;
using System.Transactions;

abstract class DisposivoElectronico//no se instancia
{
    public string Marca { get; set; }

    public DisposivoElectronico(string marca)//el contructor siempre tiene que estar
    {
        Marca = marca;
    }
   
    public abstract void Encender();//no se la que va ser, se tiene que implementar

}

class Televisor : DisposivoElectronico
{
    public Televisor(string marca) : base(marca)
    {

    }
    public override void Encender() //p
    {
        Console.WriteLine($"El Televisor {Marca} está encendido.");
    }
}
class Radio : DisposivoElectronico
{
    public Radio(string marca) : base(marca)
    {

    }
    public override void Encender() 
    {
        Console.WriteLine($"La radio {Marca} está encendida.");
    }
}
class Program
{
    static void Main()
    {
        DisposivoElectronico tv = new Televisor("Sony");

        tv.Encender();
        DisposivoElectronico radio = new Radio("Philco");

        radio.Encender();

    }
}
