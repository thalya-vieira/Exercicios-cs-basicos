﻿using System;
using System.Threading.Channels;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu salario: ");
        double salario = Convert.ToDouble(Console.ReadLine());
        double porcentagem = (salario*10)/100;

        Console.WriteLine("Seu salario de R$"+salario+" tera um bonus de R$10"+porcentagem);
        Console.WriteLine("Novo salário: R$"+(salario+porcentagem));

    }
}