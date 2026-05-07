using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite sua nota: ");
        double nota = Convert.ToDouble(Console.ReadLine());

        if(nota < 0){
            Console.WriteLine("Inválido");
        }
        if(nota < 5){
            Console.WriteLine("Reprovado");
        }
        else if(nota < 7){
            Console.WriteLine("Recuperacao");
        }
        else if(nota <= 10){
            Console.WriteLine("Aprovado");
        }
        else{
            Console.WriteLine("Inválido");
        }
    }
}