using BibliotecaGeometria;

class Program
{
    static void Main(string[] args)
    {
        var geo = new Geometria();

        Console.WriteLine("Calculadora de Geometria ");

        Console.Write("Digite o raio para calcular a área do círculo: ");
        if (double.TryParse(Console.ReadLine(), out double r))
            Console.WriteLine($"Área do círculo: {geo.AreaCirculo(r):F4}\n");

        Console.Write("Digite a largura do retângulo: ");
        double.TryParse(Console.ReadLine(), out double l);

        Console.Write("Digite a altura do retângulo: ");
        double.TryParse(Console.ReadLine(), out double h);

        Console.WriteLine($"Área do retângulo: {geo.AreaRetangulo(l, h):F4}");
        Console.WriteLine($"Perímetro do retângulo: {geo.PerimetroRetangulo(l, h):F4}");
    }
}