internal class Program
{
    private static void Main(string[] args)
    {
        int x, y, temp, soma;

        Console.WriteLine("Digite dois numeros:");
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

        if (x > y)
        {
            temp = x;
            x = y;
            y = temp;
        }

        soma = 0;
        for (int i = x + 1; i < y; i++)
        {
            if (i % 2 != 0)
            {
                soma = soma + i;
            }
        }

        Console.WriteLine("SOMA = " + soma);
    }
}