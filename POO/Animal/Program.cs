class Animal
{
    public string Nombre;
    protected int Edad;
    private string _tipo;

    public Animal(string nombre, int edad, string tipo)
    {
        this.Nombre = nombre;
        this.Edad = edad;
         Tipo = tipo;
    }
    public string Tipo {
        get { return _tipo; }
        private set { _tipo = value; } 
    }
    public  void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad} años, Tipo: {Tipo} ");

    }


}
class Perro: Animal
{
    public string Raza;
    public Perro(string nombre, int edad, string tipo, string raza): base(nombre, edad,tipo) 
    {
        Raza = raza;
    }

    public void MostrarInformacionPerro()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad} años, Tipo: {Tipo}, Raza {Raza}");
    }
 
}
class Program
{
    static void Main()
    {
        Perro perro = new Perro("Jack", 12, "Mamifero", "Callejero");
        perro.MostrarInformacionPerro();
        perro.MostrarInformacion();
    }
}