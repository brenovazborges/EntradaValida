    int resposta = 0;
    do
    {
        Console.Write("Digite um número entre 1 e 9 (ou 0 para cancelar): ");
        resposta = Convert.ToInt32(Console.ReadLine());
    }

    while(resposta < 0 || resposta > 10);
    
    if (resposta == 0)
    {
        Console.WriteLine("Operação cancelada");
    }
    
    else
    {
        Console.WriteLine($"Número selecionado = {resposta}");
    }
    
    Console.WriteLine("Volte sempre."); 