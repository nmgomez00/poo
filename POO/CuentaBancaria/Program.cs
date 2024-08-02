class CuentaBancaria
{
    private string _titular;
    private decimal _saldo;
    public CuentaBancaria(string titular, decimal saldoInicial)
    {
        //dentro de el contructor se puede asignar a las variables privadas
        // y por estar dentro de la clase 
        _titular = titular;
        _saldo = saldoInicial;
    }
    public string Titular
    {
        get { return _titular; }
        set { _titular = value; }
    }
    public decimal Saldo
    {
        get { return _saldo; }
        private set { _saldo = value; }//solo esta clase pude setear el saldo
    }
    public void Depositar(decimal cantidad)
    {
        if (cantidad > 0)
        {
            Saldo += cantidad;
            Console.WriteLine($"Depositaste {cantidad}. Saldo Actual: {Saldo}");
        }
        else
        {
            Console.WriteLine("La cantidad a depositar debe ser mayor a 0 (cero).");
        }

    }
    public void Retirar(decimal cantidad)
    {
        if (cantidad > 0 && cantidad <= Saldo)
        {
            Saldo = Saldo - cantidad;
            Console.WriteLine($"Retiraste {cantidad}. Saldo Actual: {Saldo}");
        }
        else
        {
            Console.WriteLine("Cantidad no valida.");
        }
    }
}
class Program
{
    static void Main()
    {
        CuentaBancaria cuenta = new CuentaBancaria("Ana", 2000);
        cuenta.Depositar(200);
        cuenta.Retirar(2200);

        cuenta.Titular = "Jorge";
        //cuenta.Saldo = 12345;

        Console.WriteLine($"Saldo final: de {cuenta.Titular} { cuenta.Saldo}");
    }
}