//Crie um algoritmo que:
//•	Solicite 5 notas usando FOR 
//•	Calcule a média 
//•	Se a média for menor que 7, peça nova nota (DO WHILE)

using System;
class Program
{
    static void Main()
    {
        double nota = 0;
        double media = 0;
        double soma = 0;

        while(media <7)
        {
            for(int i=1; i<=5; i++)
            {
                Console.Write($"Digite sua {i}ª nota: ");

                while(!double.TryParse(Console.ReadLine(), out nota) || nota<0 || nota > 10)
                {
                    Console.Write("Inválido. Digite nota novamente: ");
                }
                
                //nota = Convert.ToDouble(Console.ReadLine());
                soma = soma+nota;
            
            }
            media = soma/5;

            if (media < 7)
            {
                Console.WriteLine("Media "+media+" insuficiente");
            }
            
        }
        Console.WriteLine("Média  "+media+" suficiente");
    }
}



