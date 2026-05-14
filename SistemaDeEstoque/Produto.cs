class Produto
{
    //atributo 
    public string? Nome;
    public double Preco;
    public int Quantidade;


    //contrutor criar produto
    public void CriarProduto()
    {
        Console.Write($"\nDigite nome do produto: ");
        Nome = Console.ReadLine();

        Console.Write($"Preço: ");
        double.TryParse(Console.ReadLine(), out Preco);

        Console.Write($"Quantidade: ");
        int.TryParse(Console.ReadLine(), out Quantidade);
    }

    //metodo mostrar estoque
    public void MostrarEstoque()
    {
        Console.WriteLine($"\n===Mostrar Produto=== ");
        Console.Write($"Produto: {Nome}");
        Console.Write($" | Preço: {Preco}");
        Console.WriteLine($" | Total no estoque: {Quantidade}");   
    }

    //metodos
    public void AdicionarEstoque()
    {
        Console.Write($"\nDigite a quantidade para adicionar: ");
        int.TryParse(Console.ReadLine(), out int adicionar);
        Quantidade += adicionar;
    }

    public void RemoverEstoque()
    {
        Console.Write($"\nDigite a quantidade para remover: ");
        int.TryParse(Console.ReadLine(), out int remover);
        Quantidade -= remover;
    }
}