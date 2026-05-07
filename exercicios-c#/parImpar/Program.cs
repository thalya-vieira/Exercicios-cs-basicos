using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um numero: ");
        double num = Convert.ToDouble(Console.ReadLine());

        if(num%2 == 0)
        {
            Console.WriteLine("O numero é par");
        }
        else
        {
            Console.WriteLine("O numero é impar");
        }
    }
}

