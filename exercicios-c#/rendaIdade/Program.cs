using System;
class Program
{
    static void Main()
    {
        Console.Write("Idade: ");
        double idade = Convert.ToDouble(Console.ReadLine());
        Console.Write("Renda: ");
        double renda = Convert.ToDouble(Console.ReadLine());

        if(idade>=18 && renda >= 2000)
        {
            Console.WriteLine("Crédito liberado");
        }
        else
        {
            Console.WriteLine("Crédito negado");
        }
    }
}