using System.Diagnostics.Contracts;

class ContaBancaria
{
    //atributos
    public string? Titular;
    private double Saldo;

    // criando contrutor
    public ContaBancaria(string titular)
    {
        Titular = titular;
        Saldo = 0;
        Console.WriteLine($"Titular {titular}");
    }

    //metodo
    public void Depositar(double valor)
    {
        Console.WriteLine($"Deposito: {valor}");
        Saldo += valor;   
    }
    public void Sacar(double valor)
    {
        if (valor > Saldo)
        {

            Console.WriteLine("Saldo insuficiente.");
        }
        else
        {
            Saldo -= valor;
            Console.WriteLine($"Sacar: {valor}");
            Console.WriteLine("Operação concluida");
        }
    }
    public void MostrarSaldo()
    {
        Console.WriteLine($"Saldo atual: {Saldo}");
    }
}