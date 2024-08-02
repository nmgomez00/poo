class Producto
{
    private string _nombre;
    private decimal _precio;
    private int _cantidadEnStock;

    public Producto(string nombre, decimal precio, int cantidadEnStock)
    {
        _nombre = nombre;
        _precio = precio;
        _cantidadEnStock = cantidadEnStock;
    }

    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }
    public decimal Precio
    {
        get { return _precio; }
        set { _precio = value; }
    }

    public int CantidadEnStock
    {
        get { return _cantidadEnStock; }
        private set { _cantidadEnStock = value; }
    }
    public void ActualizarCantidadEnStock(int cantidad)
    {
        if (CantidadEnStock + cantidad >= 0)
        {
            CantidadEnStock += cantidad;
            Console.WriteLine($"Cantidad en Stock actualizado: {CantidadEnStock}");
        }
        else
        {
            Console.WriteLine($"Cantidad no valida para actualizar el stock.");
        }
    }
}

class Program
{
    static void Main()//static son metodos o funciones de la clase no del obj (cantidad de obj instanciados por ej...)
    {
        Producto producto = new Producto("Laptop", 1200, 50);
        Console.WriteLine($"Nombre:{producto.Nombre}");
        Console.WriteLine($"Precio:{producto.Nombre}");
        // Console.WriteLine($"Cantidad en Stock:{producto.Cantidad}");

        producto.ActualizarCantidadEnStock(20);
        producto.ActualizarCantidadEnStock(-70);
        producto.ActualizarCantidadEnStock(30);
        producto.ActualizarCantidadEnStock(-40);
    }
    //tarea clase estudiante, 3 propiedades: nombre legajo y promedio(decimal), actualizar promedio()
    //chequear notas
}