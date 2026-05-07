// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Digite o primeiro número: ");
//         double num1 = Convert.ToDouble(Console.ReadLine());

//         Console.Write("Digite o segundo número: ");
//         double num2 = Convert.ToDouble(Console.ReadLine());

//         double soma = num1 + num2;

//         Console.WriteLine("A soma é: " + soma);
//     }
// }


using System;

class Program
{
    static void Main()
    {
        Console.Write("Primeiro numero: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Segundo numero: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double soma = num1+num2;
        double subtracao = num1-num2;
        double divisao = num1/num2;
        double multiplicacao = num1*num2;

        Console.WriteLine("Soma: "+soma+"\nSubtracao: "+subtracao+"\nDivisao: "+divisao+"\nMultiplicacao: "+multiplicacao);

    }
}