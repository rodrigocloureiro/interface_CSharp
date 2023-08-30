public interface IForma
{
    double CalcularArea();
}

public class Circulo : IForma
{
    private double _raio;

    public Circulo(double raio)
    {
        _raio = raio;
    }

    public double CalcularArea()
    {
        /*
          Aqui é necessário ter a fórmula correta para gerar o valor esperado. Fórmula: pi x raio ao quadrado
        */
        return Math.PI * Math.Pow(_raio, 2);
    }

    public void PrintarCirulo()
    {
        Console.WriteLine("Eu sou um círculo.");
    }
}

public class Retangulo : IForma
{
    private int _altura;
    private int _largura;

    public Retangulo(int altura, int largura)
    {
        _altura = altura;
        _largura = largura;
    }

    public double CalcularArea()
    {
        // Aqui você precisa aplicar a fórmula: base (largura) x altura
        return _largura * _altura;
    }

    public void PrintarRetangulo()
    {
        Console.WriteLine("Eu sou um retângulo.");
    }
}

public class Triangulo : IForma
{
    private int _base;
    private int _altura;

    public Triangulo(int _base, int altura)
    {
        this._base = _base;
        this._altura = altura;
    }

    public double CalcularArea()
    {
        return (double) _base * _altura / 2;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        /*
        // Instanciando a classe retângulo
        Retangulo ret = new Retangulo(2, 1);
        // Instanciando a classe círculo
        Circulo cir = new Circulo(2);
        */

        IForma circulo = new Circulo(5);
        Circulo circulo2 = new Circulo(2);

        // No objeto circulo, o mesmo tem acesso ao que está na interface
        Console.WriteLine(circulo.CalcularArea());
        // No objeto circulo2, o mesmo tem acesso ao que é da classe
        circulo2.PrintarCirulo();
        Console.WriteLine( circulo2.CalcularArea());

        IForma retangulo = new Retangulo(5, 5);
        Retangulo retangulo2 = new Retangulo(2, 10);

        Console.WriteLine(retangulo.CalcularArea());
        retangulo2 .PrintarRetangulo();
        Console.WriteLine(retangulo2.CalcularArea());

        Console.WriteLine("=================");

        IForma forma = new Circulo(5);
        Console.WriteLine(forma.CalcularArea());
        forma = new Retangulo(4, 5);
        Console.WriteLine (forma.CalcularArea());
        forma = new Triangulo(5, 6);
        Console.WriteLine(forma.CalcularArea());

        Console.ReadKey();
    }
}
