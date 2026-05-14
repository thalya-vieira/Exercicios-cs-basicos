
Console.WriteLine("\n===Sistema de estoque===");
Produto p = new();
while (true){
    
   // int opcao;
    Console.WriteLine("\n1. Cadastrar produto");
    Console.WriteLine("2. Adicionar quantidade");
    Console.WriteLine("3. Remover quantidade");
    Console.WriteLine("4. Mostrar estoque");
    Console.WriteLine("5. Sair");

    Console.Write("opcao: ");
    int.TryParse(Console.ReadLine(), out int opcao);

    switch (opcao){
        
        case 1:
            p.CriarProduto();
            break;
        case 2:
            p.AdicionarEstoque();
            break;
        case 3:
            p.RemoverEstoque();
            break;
        case 4:
            p.MostrarEstoque();
            break;
        case 5:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opcao inválida");
            break;
    }

    if (opcao == 5)
    {
        break;
    }
}
