using System;

class Program
{
    static void Main()
    {
        double nota;

        Console.Write("Digite sua nota: ");
        double.TryParse(Console.ReadLine(), out nota);

        Console.WriteLine($"Sua nota e {nota}");
    }
}
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("===== MENU DE LANCHES =====");
//         Console.WriteLine("1 - X-Burger      R$ 15,00");
//         Console.WriteLine("2 - X-Salada      R$ 18,00");
//         Console.WriteLine("3 - Hot Dog       R$ 12,00");
//         Console.WriteLine("4 - Batata Frita  R$ 10,00");
//         Console.WriteLine("5 - Refrigerante  R$ 6,00");

//         Console.Write("\nEscolha um produto: ");

//         int opcao;

//         if (int.TryParse(Console.ReadLine(), out opcao))
//         {
//             switch (opcao)
//             {
//                 case 1:
//                     Console.WriteLine("Você escolheu X-Burger");
//                     break;

//                 case 2:
//                     Console.WriteLine("Você escolheu X-Salada");
//                     break;

//                 case 3:
//                     Console.WriteLine("Você escolheu Hot Dog");
//                     break;

//                 case 4:
//                     Console.WriteLine("Você escolheu Batata Frita");
//                     break;

//                 case 5:
//                     Console.WriteLine("Você escolheu Refrigerante");
//                     break;

//                 default:
//                     Console.WriteLine("Opção inválida!");
//                     break;
//             }
//         }
//         else
//         {
//             Console.WriteLine("Digite apenas números!");
//         }
//     }
// }