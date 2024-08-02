class Empleado
{
    private string _nombre = null!;
    private decimal _salario;

    public Empleado(string nombre, decimal salario)
    {
        Nombre = nombre;
        Salario = salario;
    }

    public string Nombre 
    {
        get {return _nombre; }
        private set {_nombre = value; }
    }
    protected decimal Salario
    {
        get { return _salario; }
        set {
            if (value > 0) {
                _salario = value;
            }
            else
            {
                Console.WriteLine("Salario invalido");
            }
        }
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Salario {Salario}");
    }

}

class Gerente : Empleado
{
    public string Departamento;
    public Gerente(string nombre,decimal salario, string departamento):base(nombre,salario)
    {
        Departamento = departamento;
    }
    public void MostrarInformacionGerente()
    {
        Console.WriteLine($"Nombre: {Nombre}, Salario {Salario}, Departamento {Departamento}" );
    }
}
class Program
{
    static void Main()
    {
        Empleado empleado = new Empleado("Pepe", 3000);
        empleado.MostrarInformacion();
        Gerente gerente = new Gerente("Marcelo", 3000, "Sistemas");
        gerente.MostrarInformacionGerente();
        gerente.MostrarInformacion();
    }
}
