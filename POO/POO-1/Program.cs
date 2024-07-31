using System.Transactions;

abstract class FormaGeometrica//no se instancia
{
    public abstract double CalcularArea();//no se la que va ser, se tiene que implementar
}
class Rectangulo: FormaGeometrica
{
    public double Largo { get; set; }
    public double Ancho { get; set; }

    public Rectangulo(double largo, double ancho)//constructor, mismo nombre que la clase
    {
        this.Largo = largo;
        this.Ancho = ancho;
    }

    public override double CalcularArea() //p
    {
        return Largo * Ancho;
    }

}
class Circulo : FormaGeometrica
{
    public double Radio { get; set; }
    //public double Ancho { get; set; }

    public Circulo(double radio)//constructor, mismo nombre que la clase
    {
        this.Radio = radio;
    }
    public override double CalcularArea()
    {
        return Math.PI * (this.Radio * this.Radio);
    }

}
class Program
{
    static void Main()
    {
        FormaGeometrica rectangulo = new Rectangulo(4,6);
        Console.WriteLine($"Area del rectangulo: {rectangulo.CalcularArea()}cm");//literal template c#
        FormaGeometrica circulo = new Circulo(4);
        Console.WriteLine($"Area del circulo es: {circulo.CalcularArea()}cm");
    }
    //agregar mas formas cuadrado, triangulo
    //clase abstracta poligonos y dentro de cada cosa, con sus subclacificaciones, pitagoras etc...
}
