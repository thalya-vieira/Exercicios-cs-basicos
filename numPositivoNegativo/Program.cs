using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um numero: ");
        double num = Convert.ToDouble(Console.ReadLine());

        if (num == 0)
        {
            Console.WriteLine("O numero é zero");
        }
        else if (num >0)
        {
            Console.WriteLine("O numero é positivo");
        }
        else
        {
            Console.WriteLine("O numero é negativo");
        }

    }
}