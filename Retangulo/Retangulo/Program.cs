using System.Globalization;

internal class Program
{
    public static void Main(string[] args)
    {
        double largura, comprimento, valor, area, precoDometro;

        CultureInfo culture = CultureInfo.InvariantCulture;

        Console.Write("Digite a largura do terreno: ");
        largura = double.Parse(Console.ReadLine(), culture);
        Console.Write("Digite o comprimento do terreno: ");
        comprimento = double.Parse(s: Console.ReadLine(), culture);
        Console.Write("Digite o valor do metro quadrado: ");
        valor = double.Parse(s: Console.ReadLine(), culture);

        area = largura * comprimento;
        precoDometro = valor * area;

        Console.WriteLine("Area do terreno = " + area.ToString("F2", culture));
        Console.WriteLine("Preco do terreno = " + precoDometro.ToString("F2", culture));
    }
}